using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using Atencao_Assistida.Classes.Funcoes;
namespace Atencao_Assistida.Forms
{
    public partial class CapturaScanner : Form
    {
        public CapturaScanner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListScanners();
            txtnomearquivo.Text = "";

            txtcodigo.Text = Parametros.Valor;


            // Set start output folder TMP
            txtsaidascanner.Text = Path.GetTempPath();
            // Set JPEG as default
          
             listBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnomearquivo.Text.Trim() != "")
            {
                VerificaTexto();
                Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
            }
            else
            {
                MessageBox.Show("Nome de Arquivo é Campo Obrigatório !");
                txtnomearquivo.Focus();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtnomearquivo.Text.Trim() != "")
            {
                VerificaTexto();
                GravaImagem();
                Close();
            }
            else
            {
                MessageBox.Show("Nome de Arquivo é Campo Obrigatório !");
                txtnomearquivo.Focus();
            }

            
        }

        private void ListScanners()
        {
            // Clear the ListBox.
            listBox1.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                listBox1.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
        }

        private void TriggerScan()
        {
            Console.WriteLine("Image succesfully scanned");
        }

        public void StartScanning()
        {
            Scanner device = null;

            this.Invoke(new MethodInvoker(delegate ()
            {

                device = listBox1.SelectedItem as Scanner;

            }));

            if (device == null)
            {
                MessageBox.Show("You need to select first an scanner device from the list",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(txtnomearquivo.Text))
            {
                MessageBox.Show("Provide a filename",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile image = new ImageFile();
            string imageExtension = "";

            this.Invoke(new MethodInvoker(delegate ()
            {
         
                image = device.ScanPNG();
                imageExtension = ".png";
               
            }));

            string sourceDir = txtsaidascanner.Text;
            string[] picList = Directory.GetFiles(sourceDir, "*.png");

            foreach (string f in picList)
            {
                try
                {
                    File.Delete(f);
                }
                catch
                {

                }
            }

            // Save the image
            var path = Path.Combine(txtsaidascanner.Text, txtnomearquivo.Text + imageExtension);

            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                }
                catch
                {

                }
            }

            image.SaveFile(path);

            pictureBox1.Image = new Bitmap(path);
        }

        private int BuscaUltimo(int valor)
        {
            var numeroimagem = "";

            var dr = Classes.Mysql.DocumentosImg.BuscaNumeroImagem(valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr.GetOrdinal("ULTIMO") != null)
                    {
                        try
                        {
                            numeroimagem = dr.GetString(dr.GetOrdinal("ULTIMO"));
                        }
                        catch
                        {
                            numeroimagem = "0";
                        }
                    }

                }

            }

            dr.Close();
            dr.Dispose();

            return int.Parse(numeroimagem) + 1;
        }

        private void GravaImagem()
        {
            var hoje = DateTime.Now;

            var codpaciente = int.Parse(txtcodigo.Text.Trim());
            var numeroimagem = BuscaUltimo(int.Parse(txtcodigo.Text.Trim()));

            var nomeimagem = txtnomearquivo.Text;
            
            ConverterImagem();

            var imagem = txtsaidascanner.Text + nomeimagem + ".jpg";
          
            try
            {
                var m = new Classes.Mysql.DocumentosImg(0,codpaciente, numeroimagem, nomeimagem, imagem);
               
                    m.Insert();

                //MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

           
            File.Delete(txtsaidascanner.Text + txtnomearquivo.Text + ".jpg");

           
        }

        private void ConverterImagem()
        {
            //--> diminui o tamanho da imagem 
            var imagem = txtsaidascanner.Text + txtnomearquivo.Text + ".jpg";

            String msg = "";
            Image imagemConvertida = pictureBox1.Image;
           
            sfd1.Filter = "*.jpg|*.jpg";
            sfd1.FileName = txtsaidascanner.Text + txtnomearquivo.Text + ".jpg";
           
            try
            {
                imagemConvertida.Save(sfd1.FileName, ImageFormat.Jpeg);
                msg = "Conversão realizada com sucesso.";
                //MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possivel converter a imagem : ");
            }

        }

        private void VerificaTexto()
        {
            var text = Utilidades.FormataNomeImagem(txtnomearquivo.Text);
            txtnomearquivo.Text = text;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
