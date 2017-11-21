using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2_Ap2_Leandro.UI.Registros
{
    public partial class FormPresupuesto : System.Web.UI.Page
    {

        private static List<PresupuestoDetalle> relacion;
        public static List<PresupuestoDetalle> PresupuestoDetalle { get; set; }
        DataTable tabla = new DataTable();
        Presupuesto presupuesto= new Presupuesto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                relacion = new List<PresupuestoDetalle>();
                PresupuestoDetalle = new List<PresupuestoDetalle>();

                tabla.Columns.AddRange(new DataColumn[3] { new DataColumn("Descripcion de Presupuesto"), new DataColumn("Meta"), new DataColumn("Logrado") });
                ViewState["PresupuestoRelacion"] = tabla;



                FechaTextbox.Text = DateTime.Now.ToString("dd/MM/yyyy");



            }
        }

        public Presupuesto llenarCampos()
        {
            presupuesto.PresupuestoId = Utilidad.TOINT(IdTextBox.Text);
            presupuesto.Fecha = Convert.ToDateTime(FechaTextbox.Text);
            presupuesto.Descripcion = DescripcionTextbox.Text;
            presupuesto.Monto = Utilidad.TOINT(MontoTextbox.Text);

            return presupuesto;
        }

        protected void LlenarGridView()
        {
            GridView1.DataSource = (DataTable)ViewState["PresupuestoRelacion"];
            GridView1.DataBind();
        }

        public void AgregarAGrid(List<PresupuestoDetalle> lista)
        {

            foreach (var list in lista)
            {
                tabla.Rows.Add(list.Descripcion, list.Meta, list.Logrado);
                ViewState["PresupuestoRelacion"] = tabla;
                this.LlenarGridView();
            }
        }


        public void LimpiarTextBox()
        {
            IdTextBox.Text = "";
            DescripcionTextbox.Text = "";
            MontoTextbox.Text = "";
            LogradoTextbox.Text = "";
            MetaTextbox.Text = "";
            FechaTextbox.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tabla.Rows.Clear();
            PresupuestoDetalle = new List<PresupuestoDetalle>();
            GridView1.DataSource = (DataTable)ViewState["PresupuestoRelacion"];
            relacion = new List<Entidades.PresupuestoDetalle>();
            GridView1.DataBind();


        }



        protected void Buscar_Click(object sender, EventArgs e)
        {
            int id = Utilidad.TOINT(IdTextBox.Text);
            presupuesto = Bll.PresupuestoBll.Buscar(p => p.PresupuestoId == id);

            if (presupuesto != null)
            {
                DescripcionTextbox.Text = presupuesto.Descripcion;
                MontoTextbox.Text = Convert.ToString(presupuesto.Monto);
                FechaTextbox.Text = Convert.ToString(presupuesto.Fecha);

                relacion = Bll.PresupuestoDetalleBll.GetList(p => p.PresupuestoId == id);
                AgregarAGrid(relacion);
            }
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            tabla = (DataTable)ViewState["PresupuestoRelacion"];
            tabla.Rows.Add(DescripcionTextbox.Text, MetaTextbox.Text, LogradoTextbox.Text);
            ViewState["Detalle"] = tabla;
            this.LlenarGridView();
        }

        protected void guardar_Click(object sender, EventArgs e)
        {
            presupuesto = llenarCampos();

            if (presupuesto.PresupuestoId > 0)
            {
                Bll.PresupuestoBll.Modificar(presupuesto);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Modificado!');</script> ");
                LimpiarTextBox();

            }
            else
            {
                Bll.PresupuestoBll.Guardar(presupuesto);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Guardado!');</script> ");
                LimpiarTextBox();
            }
        }

        protected void Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }
    }
}