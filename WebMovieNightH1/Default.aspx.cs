using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMovieNightH1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            List<Film> filmTY = FilmManager.ReturnFilmsNoGenre();
            foreach (Film item in filmTY)
            {
                lblResult.Text = ($"{item.Title,-18} {item.Year}");
            }

        }
        
    }
}