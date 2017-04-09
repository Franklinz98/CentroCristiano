using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroCristiano
{
    public partial class InterfazLider : Form
    {
        
        public InterfazLider()
        {
            InitializeComponent();
            Color();
        }

        void Color()
        {
            Botones.BackColor = Components.GetVerdeOscuro();
            ISGB.ForeColor = Components.GetBlanco();
            ISGB.BackColor = Components.GetVerde();
            ISGBbutton.ForeColor = Components.GetBlanco();
            ISGBbutton.BackColor = Components.GetVerde();
            ISGBbutton.FlatAppearance.BorderColor = Components.GetVerde();
            ISGBbutton.FlatAppearance.MouseDownBackColor = Components.GetVerdeClaro();
            ISGBbutton.FlatAppearance.MouseOverBackColor = Components.GetVerdeOscuro();
            Datos.ForeColor = Components.GetBlanco();
            Datos.BackColor = Components.GetVerde();
            Datosbutton.ForeColor = Components.GetBlanco();
            Datosbutton.BackColor = Components.GetVerde();
            Datosbutton.FlatAppearance.BorderColor = Components.GetVerde();
            Datosbutton.FlatAppearance.MouseDownBackColor = Components.GetVerdeClaro();
            Datosbutton.FlatAppearance.MouseOverBackColor = Components.GetVerdeOscuro();
            Enviar.ForeColor = Components.GetBlanco();
            Enviar.BackColor = Components.GetVerdeOscuro();
            Enviar.FlatAppearance.BorderColor = Components.GetVerdeOscuro();
            Enviar.FlatAppearance.MouseDownBackColor = Components.GetVerdeClaro();
            Enviar.FlatAppearance.MouseOverBackColor = Components.GetVerde();
            //Informe Semanal Grupo Biblico
            diaLabel.BackColor = Components.GetVerdeClaro();
            diaLabel.ForeColor = Components.GetBlanco();
            dia.BackColor = Components.GetBlanco();
            mesLabel.BackColor = Components.GetVerdeClaro();
            mesLabel.ForeColor = Components.GetBlanco();
            mes.BackColor = Components.GetBlanco();
            annoLabel.BackColor = Components.GetVerdeClaro();
            annoLabel.ForeColor = Components.GetBlanco();
            anno.BackColor = Components.GetBlanco();
            PastorSLabel.BackColor = Components.GetVerdeClaro();
            PastorSLabel.ForeColor = Components.GetBlanco();
            PastorS.BackColor = Components.GetBlanco();
            CoordinadorLabel.BackColor = Components.GetVerdeClaro();
            CoordinadorLabel.ForeColor = Components.GetBlanco();
            Coordinador.BackColor = Components.GetBlanco();
            SdeRLabel.BackColor = Components.GetVerdeClaro();
            SdeRLabel.ForeColor = Components.GetBlanco();
            SdeR.BackColor = Components.GetBlanco();
            FelipeGLabel.BackColor = Components.GetVerdeClaro();
            FelipeGLabel.ForeColor = Components.GetBlanco();
            FelipeG.BackColor = Components.GetBlanco();
            CodigoLabel.BackColor = Components.GetVerdeClaro();
            CodigoLabel.ForeColor = Components.GetBlanco();
            Codigo.BackColor = Components.GetBlanco();
            NombreGLabel.BackColor = Components.GetVerdeClaro();
            NombreGLabel.ForeColor = Components.GetBlanco();
            NombreG.BackColor = Components.GetBlanco();

            AsistenciaLabel.BackColor = Components.GetVerde();
            AsistenciaLabel.ForeColor = Components.GetBlanco();

            FelipesLabel.BackColor = Components.GetVerdeClaro();
            FelipesLabel.ForeColor = Components.GetBlanco();
            Felipes.BackColor = Components.GetBlanco();
            EtiopesLabel.BackColor = Components.GetVerdeClaro();
            EtiopesLabel.ForeColor = Components.GetBlanco();
            Etiopes.BackColor = Components.GetBlanco();
            AmigosLabel.BackColor = Components.GetVerdeClaro();
            AmigosLabel.ForeColor = Components.GetBlanco();
            Amigos.BackColor = Components.GetBlanco();
            NinosLabel.BackColor = Components.GetVerdeClaro();
            NinosLabel.ForeColor = Components.GetBlanco();
            Ninos.BackColor = Components.GetBlanco();
            AusentesLabel.BackColor = Components.GetVerdeClaro();
            AusentesLabel.ForeColor = Components.GetBlanco();
            Ausentes.BackColor = Components.GetBlanco();
            VisitasLabel.BackColor = Components.GetVerdeClaro();
            VisitasLabel.ForeColor = Components.GetBlanco();
            Visitas.BackColor = Components.GetBlanco();
            ConversionALabel.BackColor = Components.GetVerdeClaro();
            ConversionALabel.ForeColor = Components.GetBlanco();
            ConversionA.BackColor = Components.GetBlanco();
            ConversionNLabel.BackColor = Components.GetVerdeClaro();
            ConversionNLabel.ForeColor = Components.GetBlanco();
            ConversionN.BackColor = Components.GetBlanco();
            ReconciliadosLabel.BackColor = Components.GetVerdeClaro();
            ReconciliadosLabel.ForeColor = Components.GetBlanco();
            Reconciliados.BackColor = Components.GetBlanco();

            FinancieroLabel.BackColor = Components.GetVerde();
            FinancieroLabel.ForeColor = Components.GetBlanco();

            DiezmoLabel.BackColor = Components.GetVerdeClaro();
            DiezmoLabel.ForeColor = Components.GetBlanco();
            Diezmo.BackColor = Components.GetBlanco();
            OfrendaLabel.BackColor = Components.GetVerdeClaro();
            OfrendaLabel.ForeColor = Components.GetBlanco();
            Ofrenda.BackColor = Components.GetBlanco();
            TotalLabel.BackColor = Components.GetVerdeClaro();
            TotalLabel.ForeColor = Components.GetBlanco();
            Total.BackColor = Components.GetBlanco();

            //Datos

            ReporteLabel.BackColor = Components.GetVerdeOscuro();
            ReporteLabel.ForeColor = Components.GetBlanco();
            ParticipacionLabel.BackColor = Components.GetVerde();
            ParticipacionLabel.ForeColor = Components.GetBlanco();

            MALabel.BackColor = Components.GetVerdeClaro();
            MALabel.ForeColor = Components.GetBlanco();
            MA.BackColor = Components.GetBlanco();
            ConsolidacionLabel.BackColor = Components.GetVerdeClaro();
            ConsolidacionLabel.ForeColor = Components.GetBlanco();
            Consolidacion.BackColor = Components.GetBlanco();
            DiscipuladoLabel.BackColor = Components.GetVerdeClaro();
            DiscipuladoLabel.ForeColor = Components.GetBlanco();
            Discipulado.BackColor = Components.GetBlanco();

            AsistenciaDLabel.BackColor = Components.GetVerde();
            AsistenciaDLabel.ForeColor = Components.GetBlanco();

            HermanosLabel.BackColor = Components.GetVerdeClaro();
            HermanosLabel.ForeColor = Components.GetBlanco();
            HermanosD.BackColor = Components.GetBlanco();
            AmigosDLabel.BackColor = Components.GetVerdeClaro();
            AmigosDLabel.ForeColor = Components.GetBlanco();
            AmigosD.BackColor = Components.GetBlanco();
            NinosDLabel.BackColor = Components.GetVerdeClaro();
            NinosDLabel.ForeColor = Components.GetBlanco();
            NinosD.BackColor = Components.GetBlanco();

            AsistenciaDatosLabel.BackColor = Components.GetVerde();
            AsistenciaDatosLabel.ForeColor = Components.GetBlanco();

            VEALabel.BackColor = Components.GetVerdeClaro();
            VEALabel.ForeColor = Components.GetBlanco();
            VEA.BackColor = Components.GetBlanco();
            ELLabel.BackColor = Components.GetVerdeClaro();
            ELLabel.ForeColor = Components.GetBlanco();
            EL.BackColor = Components.GetBlanco();

            DatosLabel.BackColor = Components.GetVerdeOscuro();
            DatosLabel.ForeColor = Components.GetBlanco();

            FLLabel.BackColor = Components.GetVerdeClaro();
            FLLabel.ForeColor = Components.GetBlanco();
            FL.BackColor = Components.GetBlanco();
            AsistenteLabel.BackColor = Components.GetVerdeClaro();
            AsistenteLabel.ForeColor = Components.GetBlanco();
            Asistente.BackColor = Components.GetBlanco();
            AnfitrionLabel.BackColor = Components.GetVerdeClaro();
            AnfitrionLabel.ForeColor = Components.GetBlanco();
            Anfitrion.BackColor = Components.GetBlanco();
            MNLabel.BackColor = Components.GetVerdeClaro();
            MNLabel.ForeColor = Components.GetBlanco();
            MN.BackColor = Components.GetBlanco();
            DTLabel.BackColor = Components.GetVerdeClaro();
            DTLabel.ForeColor = Components.GetBlanco();
            Direccion.BackColor = Components.GetBlanco();
            Telefono.BackColor = Components.GetBlanco();
            DHLabel.BackColor = Components.GetVerdeClaro();
            DHLabel.ForeColor = Components.GetBlanco();
            diaD.BackColor = Components.GetBlanco();
            mesD.BackColor = Components.GetBlanco();
            anoD.BackColor = Components.GetBlanco();
            ObservacionesLabel.BackColor = Components.GetVerdeClaro();
            ObservacionesLabel.ForeColor = Components.GetBlanco();
            Observaciones.BackColor = Components.GetBlanco();
        }

        bool activar()
        {
            return (!string.IsNullOrEmpty(dia.Text) && !string.IsNullOrEmpty(mes.Text) && !string.IsNullOrEmpty(anno.Text) && !string.IsNullOrEmpty(PastorS.Text) && !string.IsNullOrEmpty(Coordinador.Text) && !string.IsNullOrEmpty(SdeR.Text)
                  && !string.IsNullOrEmpty(FelipeG.Text) && !string.IsNullOrEmpty(Codigo.Text) && !string.IsNullOrEmpty(NombreG.Text) && !string.IsNullOrEmpty(Felipes.Text) && !string.IsNullOrEmpty(Etiopes.Text) && !string.IsNullOrEmpty(Amigos.Text)
                   && !string.IsNullOrEmpty(Ninos.Text) && !string.IsNullOrEmpty(Ausentes.Text) && !string.IsNullOrEmpty(Visitas.Text) && !string.IsNullOrEmpty(ConversionA.Text) && !string.IsNullOrEmpty(ConversionN.Text) && !string.IsNullOrEmpty(Reconciliados.Text)
                    && !string.IsNullOrEmpty(Diezmo.Text) && !string.IsNullOrEmpty(Ofrenda.Text) && !string.IsNullOrEmpty(MA.Text) && !string.IsNullOrEmpty(Consolidacion.Text) && !string.IsNullOrEmpty(Discipulado.Text) && !string.IsNullOrEmpty(HermanosD.Text)
                     && !string.IsNullOrEmpty(AmigosD.Text) && !string.IsNullOrEmpty(NinosD.Text) && !string.IsNullOrEmpty(VEA.Text) && !string.IsNullOrEmpty(EL.Text) && !string.IsNullOrEmpty(Anfitrion.Text) && !string.IsNullOrEmpty(MN.Text)
                      && !string.IsNullOrEmpty(Direccion.Text) && !string.IsNullOrEmpty(Telefono.Text) && !string.IsNullOrEmpty(diaD.Text) && !string.IsNullOrEmpty(mesD.Text) && !string.IsNullOrEmpty(anoD.Text) && !string.IsNullOrEmpty(hora.Text) 
                       && !string.IsNullOrEmpty(min.Text) && !string.IsNullOrEmpty(Observaciones.Text));
        }

        private void ISGBbutton_Click(object sender, EventArgs e)
        {
            Formulario.SelectedTab = ISGBTab;
        }

        private void Datosbutton_Click(object sender, EventArgs e)
        {
            Formulario.SelectedTab = DatosTab;
        }
        private void Box_TextChanged(object sender, EventArgs e)
        {
            if ((((!(string.IsNullOrEmpty(Diezmo.Text))) && (Diezmo.Text.Length > 2)) && (!(string.IsNullOrEmpty(Ofrenda.Text))) && (Ofrenda.Text.Length > 2)) == true)
            {
                Total.Text = Convert.ToString(int.Parse(Diezmo.Text) + int.Parse(Ofrenda.Text));
            }
            else
            {
                Total.Text = "";
            }
            if (activar() == true)
            {
                Enviar.Enabled = true;
                Enviar.Visible = true;
            }
        }

        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void Texto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void NumerosLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (!(char.IsDigit(e.KeyChar))) && (e.KeyChar != '#') && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
