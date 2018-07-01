using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.NintyIPC2;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        String nuser, numu, ape, sus, cor, cc, contra= "";
        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubIS_Click(object sender, EventArgs e)
        {
            ServicioPruebaClient checkUser = new ServicioPruebaClient();
            String uid = checkUser.ConsultarUsuario(user.Value,password.Value);
            UserName.InnerHtml = uid;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            nuser = uname.Value;
            ape = apellido.Value;
            contra = password1.Value;
            cor = Umail.Value;
            if (int.Parse(nu.Value) < 99 && int.Parse(nu.Value) > 0) 
            {
                numu = nu.Value;
            }
            else
            {
                numu = "99";
            }
            
            if (op1.Checked)
            {
                sus = "1";
            }
            else
            {
                sus = "2";
            }
            cc = cnumber.Value;
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + nuser +" "+ ape +" "+contra+" "+cor+" "+nuser+" "+ sus +" "+cc+" "+numu+ "');", true);
            nombre.InnerHtml = "Nombre: "+nuser +" "+ ape;
            Pcorreo.InnerHtml = "Correo: " + cor;
            int cuser = int.Parse(numu) * 2;
            PUsuarios.InnerHtml = "Monto por Usuarios: $." + cuser+".00";
            if(sus == "1")
            {
                Psuscripcion.InnerHtml = "Monto por Suscripcion: $." + 4.99;
                total.InnerHtml = "Total: $." +(4.99 + cuser);
            } else
            {
                Psuscripcion.InnerHtml = "Monto por Suscripcion: $." + 14.99;
                total.InnerHtml = "Total: $." +(14.99 + cuser);
            }
            
            
            tab1.Visible = false;
            confirmar.Visible = true;
        }
        protected void ConfirmarPago_Click(object sender, EventArgs e)
        {
            if (op1.Checked)
            {
                sus = "1";
            }
            else
            {
                sus = "2";
            }
            ServicioPruebaClient addAdmin = new ServicioPruebaClient();
            addAdmin.AgregarAdmin(uname.Value,apellido.Value,Umail.Value,cnumber.Value,"1",sus,nu.Value,password1.Value);
        }
    }
}