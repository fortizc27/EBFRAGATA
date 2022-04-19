using System;
using System.Data;
using Entity;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace WinFormsApp
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            var result = IApp.rolesService.GetById(new RolesEntity()
            {
                IdRol = MenuPrincipal.rolusuario
            });

            ppReportes.Visible = result.Reportes;
            ppBitacoras.Visible = result.Bitacoras;
        }

        public void GuardarDocumento(string html, string nombre)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = nombre + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document document = new Document(PageSize.LETTER, 25, 25, 25, 25);

                    PdfWriter pdfWriter = PdfWriter.GetInstance(document, stream);
                    document.Open();

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.FRAGATA___logo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(100, 80);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(document.LeftMargin, document.Top - 60);
                    document.Add(img);

                    using (StringReader stringReader = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, document, stringReader);
                    }

                    document.Close();

                    stream.Close();
                }

            }
        }

        private void btnBuscar4_Click(object sender, EventArgs e)
        {
            try
            {
                string paginahtml_texto = Properties.Resources.Bitacora1.ToString();

                var entity = new BitacorasEntity
                {
                    Usuario = txtUsuario1.Text,
                    FechaInicio = dtFechaInicial2.Value,
                    FechaFin = dtFechaFinal2.Value
                };
                string filas = string.Empty;

                foreach (var row in IApp.bitacorasService.GetByUser(entity))
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Usuario.ToString() + "</td>";
                    filas += "<td>" + row.Registro.ToString() + "</td>";
                    filas += "<td>" + row.Accion.ToString() + "</td>";
                    filas += "</tr>";
                }

                paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", txtUsuario1.Text);
                paginahtml_texto = paginahtml_texto.Replace("@FECHAINICIO", dtFechaInicial2.Text);
                paginahtml_texto = paginahtml_texto.Replace("@FECHAFIN", dtFechaFinal2.Text);
                paginahtml_texto = paginahtml_texto.Replace("@No", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

                GuardarDocumento(paginahtml_texto, "Bitacora-");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            try
            {
                string paginahtml = Properties.Resources.Categoria.ToString();

                var entity = new ClientesEntity
                {
                    Categoria = cbCategoria.SelectedItem.ToString()
                };

                string filas = string.Empty;

                foreach (var row in IApp.clientesService.GetCategoria(entity))
                {
                    filas += "<tr>";
                    filas += "<td>" + row.IdCliente.ToString() + "</td>";
                    filas += "<td>" + row.Nombre.ToString() + "</td>";
                    filas += "</tr>";
                }

                paginahtml = paginahtml.Replace("@CATEGORIA", cbCategoria.SelectedItem.ToString());
                paginahtml = paginahtml.Replace("@No", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                paginahtml = paginahtml.Replace("@FILAS", filas);

                GuardarDocumento(paginahtml, "Categorias-");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            try
            {
                string paginahtml = Properties.Resources.FichaTecnica.ToString();

                string filas = string.Empty;
                var cliente = IApp.clientesService.GetById(new ClientesEntity
                {
                    IdCliente = Convert.ToInt32(txtIdCliente.Text)
                });

                var ficha = IApp.fichasTecService.GetLista(new FichasTecEntity
                {
                    IdAtleta = Convert.ToInt32(txtIdCliente.Text)
                });

                foreach (var row in ficha)
                {
                    filas += "<tr><td colspan='3'><table class='border' style='width:100%;'><thead><tr style='background-color:#D8D8D8'>";
                    filas += "<th>" + row.Fecha.ToString("D") + "</th>";
                    filas += "</tr></thead><tbody><tr><td>Padecimientos</td>";
                    filas += "<td>" + row.Padecimientos.ToString() + "</td>";
                    filas += "</tr><tr><td>Peso</td>";
                    filas += "<td>" + row.Peso.ToString() + "</td>";
                    filas += "</tr><tr><td>Altura</td>";
                    filas += "<td>" + row.Altura.ToString() + "</td>";
                    filas += "</tr><tr><td>Lateralidad</td>";
                    filas += "<td>" + row.Lateralidad.ToString() + "</td>";
                    filas += "</tr><tr><td>Alcance</td>";
                    filas += "<td>" + row.Alcance.ToString() + "</td>";
                    filas += "</tr><tr><td>Talla</td>";
                    filas += "<td>" + row.Talla.ToString() + "</td>";
                    filas += "</tr></tbody></table></td></tr><tr><td colspan='6'><table class='border' style='width:100%;'><thead></thead><tbody><tr>";
                    filas += "<td>Pecho</td>";
                    filas += "<td>" + row.Pecho.ToString() + "</td>";
                    filas += "<td>Abdomen</td>";
                    filas += "<td>" + row.Abdomen.ToString() + "</td>";
                    filas += "<td>Gluteo</td>";
                    filas += "<td>" + row.Gluteo.ToString() + "</td>";
                    filas += "</tr><tr>";
                    filas += "<td>Bicep Derecho</td>";
                    filas += "<td>" + row.BicepD.ToString() + "</td>";
                    filas += "<td>Bicep Izquierdo</td>";
                    filas += "<td>" + row.BicepI.ToString() + "</td>";
                    filas += "</tr><tr>";
                    filas += "<td>Muslo Derecho</td>";
                    filas += "<td>" + row.MusloD.ToString() + "</td>";
                    filas += "<td>Muslo Izquierdo</td>";
                    filas += "<td>" + row.MusloI.ToString() + "</td>";
                    filas += "</tr><tr>";
                    filas += "<td>Pantorrilla Derecho</td>";
                    filas += "<td>" + row.PantorrillaD.ToString() + "</td>";
                    filas += "<td>Pantorrilla Izquierdo</td>";
                    filas += "<td>" + row.PantorrillaI.ToString() + "</td>";
                    filas += "</tr></tbody></table></td></tr>";
                }

                paginahtml = paginahtml.Replace("@No", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                paginahtml = paginahtml.Replace("@CLIENTE", cliente.Nombre);
                paginahtml = paginahtml.Replace("@FECHAINICIO", dtFechaInicial1.Text);
                paginahtml = paginahtml.Replace("@FECHAFIN", dtFechaFinal1.Text);
                paginahtml = paginahtml.Replace("@FILAS", filas);

                GuardarDocumento(paginahtml, "FichaTecnica-");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            try
            {
                string paginahtml = Properties.Resources.Competitivo.ToString();

                var entity = new ClientesEntity
                {
                    Categoria = "Boxeo Competitivo"
                };

                string filas = string.Empty;

                foreach (var row in IApp.clientesService.GetCategoria(entity))
                {
                    if ((txtPeso.Text != "") && (txtEdad.Text != ""))
                    {
                        if ((row.Peso == int.Parse(txtPeso.Text)) && (int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(row.FechaNac.ToString("yyyy"))) == int.Parse(txtEdad.Text))
                        {
                            filas += "<tr>";
                            filas += "<td>" + row.IdCliente.ToString() + "</td>";
                            filas += "<td>" + row.Nombre.ToString() + "</td>";
                            filas += "<td>" + row.FechaNac.ToString("d") + "</td>";
                            filas += "<td>" + row.Peso.ToString() + "</td>";
                            filas += "</tr>";
                        }
                    }
                    else if (txtPeso.Text != "")
                    {
                        if (row.Peso == int.Parse(txtPeso.Text))
                        {
                            filas += "<tr>";
                            filas += "<td>" + row.IdCliente.ToString() + "</td>";
                            filas += "<td>" + row.Nombre.ToString() + "</td>";
                            filas += "<td>" + row.FechaNac.ToString("d") + "</td>";
                            filas += "<td>" + row.Peso.ToString() + "</td>";
                            filas += "</tr>";
                        }
                    }
                    else if (txtEdad.Text != "")
                    {
                        if ((int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(row.FechaNac.ToString("yyyy"))) == int.Parse(txtEdad.Text))
                        {
                            filas += "<tr>";
                            filas += "<td>" + row.IdCliente.ToString() + "</td>";
                            filas += "<td>" + row.Nombre.ToString() + "</td>";
                            filas += "<td>" + row.FechaNac.ToString("d") + "</td>";
                            filas += "<td>" + row.Peso.ToString() + "</td>";
                            filas += "</tr>";
                        }
                    }
                }

                paginahtml = paginahtml.Replace("@No", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                paginahtml = paginahtml.Replace("@FILAS", filas);

                GuardarDocumento(paginahtml, "Competitivo-");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar5_Click(object sender, EventArgs e)
        {
            try
            {
                string paginahtml_texto = Properties.Resources.Bitacora1.ToString();

                var entity = new BitacorasEntity
                {
                    Usuario = txtUsuario2.Text,
                    FechaInicio = dtFechaInicial3.Value,
                    FechaFin = dtFechaFinal3.Value
                };
                string filas = string.Empty;

                foreach (var row in IApp.bitacorasService.GetByUser(entity))
                {
                    if (row.Accion.Contains(txtMovimiento.Text.ToUpper()))
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.Usuario.ToString() + "</td>";
                        filas += "<td>" + row.Registro.ToString() + "</td>";
                        filas += "<td>" + row.Accion.ToString() + "</td>";
                        filas += "</tr>";
                    }
                }

                paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", txtUsuario2.Text);
                paginahtml_texto = paginahtml_texto.Replace("@FECHAINICIO", dtFechaInicial3.Text);
                paginahtml_texto = paginahtml_texto.Replace("@FECHAFIN", dtFechaFinal3.Text);
                paginahtml_texto = paginahtml_texto.Replace("@No", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

                GuardarDocumento(paginahtml_texto, "Bitacora-");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
