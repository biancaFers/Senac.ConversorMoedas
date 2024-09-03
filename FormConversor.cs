using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senac.ConversorMoedas
{
    public partial class FormConversor : Form
    {
        decimal valorDolar_Dolar = 1;
        decimal valorReal_Dolar = 0.18m;
        decimal valorEuro_Dolar = 1.11m;
        decimal valorIene_Dolar = 0.0068m;
        decimal valorBitcoin_Dolar = 0.000017m;
        public FormConversor()
        {
            InitializeComponent();
        }

        private void comboBoxMoedaOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMoedaOrigem.Text)
            {
                case "Real":
                    pictureBoxImagemOrigem.Image = Image.FromFile(@"..\..\..\Imagens\real.png");
                    break;
                case "Dólar":
                    pictureBoxImagemOrigem.Image = Image.FromFile(@"..\..\..\Imagens\dolar.png");
                    break;
                case "Euro":
                    pictureBoxImagemOrigem.Image = Image.FromFile(@"..\..\..\Imagens\euro.png");
                    break;
                case "Iene":
                    pictureBoxImagemOrigem.Image = Image.FromFile(@"..\..\..\Imagens\yen.png");
                    break;
                case "Bitcoin":
                    pictureBoxImagemOrigem.Image = Image.FromFile(@"..\..\..\Imagens\bitcoin.png");
                    break;
            }
        }

        private void comboBoxMoedaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMoedaDestino.Text)
            {
                case "Real":
                    pictureBoxImagemDestino.Image = Image.FromFile(@"..\..\..\Imagens\real.png");
                    break;
                case "Dólar":
                    pictureBoxImagemDestino.Image = Image.FromFile(@"..\..\..\Imagens\dolar.png");
                    break;
                case "Euro":
                    pictureBoxImagemDestino.Image = Image.FromFile(@"..\..\..\Imagens\euro.png");
                    break;
                case "Iene":
                    pictureBoxImagemDestino.Image = Image.FromFile(@"..\..\..\Imagens\yen.png");
                    break;
                case "Bitcoin":
                    pictureBoxImagemDestino.Image = Image.FromFile(@"..\..\..\Imagens\bitcoin.png");
                    break;
            }
        }
        public decimal ConverteValores(decimal valorOrigem, string moedaDestino, string moedaDestino)
        {

        }
    }
}
