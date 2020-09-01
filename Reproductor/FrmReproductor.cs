using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class FrmReproductor : Form
    {
        public FrmReproductor()
        {
            InitializeComponent();
            SubMenuDisable();
        }
        private void SubMenuDisable()
        {
            panelSubMenuMedios.Visible = false;
            panelListaReprodMenu.Visible = false;
            panelConfiguracion.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubMenuMedios.Visible)
            {
                panelSubMenuMedios.Visible = false;
            }
            if (panelListaReprodMenu.Visible)
            {
                panelListaReprodMenu.Visible = false;
            }
            if (panelConfiguracion.Visible)
            {
                panelConfiguracion.Visible = false;
            }
        }
        private void ShowSubMenu(Panel SubMenu)
        {
            if (!SubMenu.Visible)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }
        #region menu de medios
        #endregion
        private void btnMedios_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuMedios);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            HideSubMenu();
        }
        #region lista de reproducion
        #endregion
        private void btnListaReprod_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelListaReprodMenu);
        }
        #region ecualizador
        #endregion
        private void btnEcualizador_Click(object sender, EventArgs e)
        {
            //Hace algo
        }
        #region configuracion
        #endregion
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelConfiguracion);
        }
        private Form FormularioActivo = null;
        private void OpenChildForm(Form FormularioHijo)
        {
            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
                FormularioActivo = FormularioHijo;
                FormularioHijo.TopLevel = false;
                FormularioHijo.FormBorderStyle = FormBorderStyle.None;
                FormularioHijo.Dock = DockStyle.Fill;
                panelHijoForm.Controls.Add(FormularioHijo);
                panelHijoForm.Tag = FormularioHijo;
                FormularioHijo.BringToFront();
                FormularioHijo.Show();
            }
        }
    }
}
