﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelWebSite.PaqueteWS;

namespace TravelWebSite
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
            PaquetesPopularesWS paquetesWS = new PaquetesPopularesWS();
            string resultado = paquetesWS.PAQUETES();
            LtPaquetePopular.Text = resultado;
            resultado = paquetesWS.DESTINOS();
            LtDestinoPopular.Text = resultado;

            resultado = paquetesWS.BOLETINFOOTER();
            LtBoletin.Text = resultado;

            resultado = paquetesWS.RECOMENDADOS();
            LtRecomendados.Text = resultado;


        }
        
    }
}