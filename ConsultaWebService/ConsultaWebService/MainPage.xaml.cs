using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ConsultaWebService.service;
using ConsultaWebService.models;

namespace ConsultaWebService
{
	public partial class MainPage : ContentPage
	{
        DataService DAL;

        public MainPage()
		{
			InitializeComponent();
            DAL = new DataService();
		}

        private void btncarregar_Clicked(object sender, EventArgs e)
        {
            buscarCep();
        }

        async void buscarCep()
        {
            endereco end;
            end = await DAL.buscarendereco(txtcep1.Text);
            lblCEP.Text = "CEP: "+end.cep;
            lblLog.Text = "Logradouro: "+end.logradouro;
            lblbairro.Text = "Bairro: "+end.bairro;
            lbllocalidade.Text = "Localidade: "+end.localidade;
            lblUF.Text = "UF: "+end.uf;
        }
       
    }
}
