using Log;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sap.Data.Hana;

namespace Model.Query
{
    public class DbQuery : IDbQuery
    {
        private SqlConnection connection = null;
        private readonly string connectionString;
        private readonly string SCHEMA;
        private readonly IEventLogStore CsvGeneratorLog;

        public DbQuery(IEventLogStore csvGeneratorLog)
        {
            CsvGeneratorLog = csvGeneratorLog;
            this.connectionString = ConfigurationManager.ConnectionStrings["SAPSQlContext"].ConnectionString;
            this.SCHEMA = ConfigurationSettings.AppSettings.Get("schema").ToString();
        }

        /// <summary>
        /// Funcion para traer el listado de los documentos que se van a procesar, el orden de los campos puede varias pero no se puede cambiar el nombre ni disminuir la cantidad
        /// </summary>
        /// <returns> Devuelve una datatable. Columnas son los campos del query y cada fila es un documento </returns>
        public DataTable GetDocumentsData()
        {
            try
            {
                string queryString = "select \"DOCNUM\", \"idnumeracion\", \"numero\", \"idambiente\", \"fechadocumento\", \"fechavencimiento\", \"tipofactura\", \"tipooperacion\", \"notas\", \"moneda\", \"cufe\", \"idreporte\", \"correocopia\", \"FP_idmetodopago\", " +
                                    "\"FP_idmediopago\", \"FP_fechavencimiento\", \"FP_identificador\", \"FP_dias\", \"idconceptonota\", \"REF_idnumeracion\", \"REF_numero\", \"TDC_fecha\", \"TDC_moneda\",\"TDC_cambiominimo\", \"TDC_tasarepresentativa\", \"ENT_fecha\", \"ENT_idciudad\",  " +
                                    "\"ENT_direccion\", \"ENT_codigopostal\", \"ENT_TRANS_idtipopersona\", \"ENT_TRANS_idactividadeconomica\", \"ENT_TRANS_nombrecomercial\", \"ENT_TRANS_idciudad\", \"ENT_TRANS_direccion\",  " +
                                    "\"ENT_TRANS_codigopostal\", \"ENT_TRANS_nombres\", \"ENT_TRANS_apellidos\", \"ENT_TRANS_idtipodocumentoidentidad\", \"ENT_TRANS_identificacion\", \"ENT_TRANS_digitoverificacion\",  " +
                                    "\"ENT_TRANS_idtiporegimen\", \"ENT_TRANSDF_Idciudad\", \"ENT_TRANSDF_direccion\", \"ENT_TRANSDF_codigopostal\", \"ENT_TRANS_matriculamercantil\", \"ENT_TRANS_emailcontacto\", \"ENT_TRANS_emailentrega\",  " +
                                    "\"ENT_TRANS_telefono\", \"ENT_TRANS_obligaciones\", \"ENT_metododepago\", \"ENT_condicionesdeentrega\", \"FACT_idtipopersona\", \"FACT_idactividadeconomica\", \"FACT_nombrecomercial\", \"FACT_idciudad\",  " +
                                    "\"FACT_direccion\", \"FACT_codigopostal\", \"FACT_nombres\", \"FACT_apellidos\", \"FACT_idtipodocumentoidentidad\", \"FACT_identificacion\", \"FACT_digitoverificacion\", \"FACT_idtiporegimen\",  " +
                                    "\"FACT_DIR_idciudad\", \"FACT_DIR_direccion\", \"FACT_DIR_codigopostal\", \"FACT_matriculamercantil\", \"FACT_emailcontacto\", \"FACT_emailentrega\", \"FACT_telefono\", \"FACT_obligaciones\",  " +
                                    "\"ADQUIR_idtipopersona\", \"ADQUIR_idactividadeconomica\", \"ADQUIR_nombrecomercial\", \"ADQUIR_idciudad\", \"ADQUIR_direccion\", \"ADQUIR_codigopostal\", \"ADQUIR_nombres\", \"ADQUIR_apellidos\",  " +
                                    "\"ADQUIR_idtipodocumentoidentidad\", \"ADQUIR_identificacion\", \"ADQUIR_digitoverificacion\", \"ADQUIR_idtiporegimen\", \"ADQUIR_DIR_idciudad\", \"ADQUIR_DIR_direccion\", \"ADQUIR_DIR_codigopostal\",  " +
                                    "\"ADQUIR_matriculamercantil\", \"ADQUIR_emailcontacto\", \"ADQUIR_emailentrega\", \"ADQUIR_telefono\", \"ADQUIR_obligaciones\",\"ORDENC_codigo\", \"TOTAL_totalbruto\", \"TOTAL_baseimponible\", \"TOTAL_totalbrutoconimpuestos\",  " +
                                    "\"TOTAL_totaldescuento\", \"TOTAL_totalcargos\", \"TOTAL_totalanticipos\", \"TOTAL_totalapagar\", \"TOTAL_payableroundingamount\"  from " + SCHEMA + ".\"DATOS_GENERALES\"";


                //using (connection = new SqlConnection(connectionString))
                //{
                //SqlCommand command = new SqlCommand(queryString, connection);
                try
                    {
                        return QueryResult(connectionString, queryString);
                    }
                    catch (SqlException exp)
                    {
                        CsvGeneratorLog.StoreLog($"{this.ToString()}_GetDocumentsData_query_sql  {exp.Message}", EventLogEntryType.Error);
                        return null;
                    }
                    catch (Exception ex)
                    {
                        CsvGeneratorLog.StoreLog($"{this.ToString()}_GetDocumentsData_query  {ex.Message}", EventLogEntryType.Error);
                        return null;
                    }
                //}
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_GetDocumentsData  {exp.Message}", EventLogEntryType.Error);
                return null;
            }
            finally
            {
 //               connection.Close();
            }
        }


        /// <summary>
        /// Funcion para traer el listado de los anticipos correspondientes a los documentos que se procesaran, 
        /// el orden de los campos puede varias pero no se puede cambiar el nombre ni disminuir la cantidad
        /// </summary>
        /// <returns> Devuelve una datatable. Columnas son los campos del query y cada fila es uno de los Anticipos </returns>
        public DataTable GetAnticiposData()
        {
            try
            {
                string queryString = "select \"DOCNUM\", \"ANTICIPO_identificador\", \"ANTICIPO_valor\", \"ANTICIPO_fecha\" from " + SCHEMA + ".\"ANTICIPO\"";

                //using (connection = new SqlConnection(connectionString))
                //{
                //SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    return QueryResult(connectionString, queryString);
                }
                    catch (Exception ex)
                    {
                        CsvGeneratorLog.StoreLog($"{this.ToString()}_GetAnticiposData_query  {ex.Message}", EventLogEntryType.Error);
                        return null;
                    }
                //}
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_GetAnticiposData  {exp.Message}", EventLogEntryType.Error);
                return null;
            }
            finally
            {
  //              connection.Close();
            }
        }

        /// <summary>
        /// Funcion para traer el listado de los Descuentos correspondientes a los documentos que se procesaran, 
        /// el orden de los campos puede varias pero no se puede cambiar el nombre ni disminuir la cantidad
        /// </summary>
        /// <returns> Devuelve una datatable. Columnas son los campos del query y cada fila es uno de los Descuentos  </returns>
        public DataTable GetDescuentosData()
        {
            try
            {
                string queryString = "select \"DOCNUM\", \"DESC_idconcepto\", \"DESC_escargo\", \"DESC_descripcion\", \"DESC_porcentaje\", \"DESC_base\", \"DESC_valor\" from " + SCHEMA + ".\"DESCUENTOS\"";

                //using (connection = new SqlConnection(connectionString))
                //{
                //SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    return QueryResult(connectionString, queryString);
                }
                    catch (Exception ex)
                    {
                        CsvGeneratorLog.StoreLog($"{this.ToString()}_GetDescuentosData_query  {ex.Message}", EventLogEntryType.Error);
                        return null;
                    }
                //}
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_GetDescuentosData  {exp.Message}", EventLogEntryType.Error);
                return null;
            }
            finally
            {
  //              connection.Close();
            }
        }

        /// <summary>
        /// Funcion para traer el listado de los impuestos correspondientes a los documentos que se procesaran, 
        /// el orden de los campos puede varias pero no se puede cambiar el nombre ni disminuir la cantidad
        /// </summary>
        /// <returns> Devuelve una datatable. Columnas son los campos del query y cada fila es uno de los Impuestos </returns>
        public DataTable GetImpuestosData()
        {
            try
            {
                string queryString = "select \"DOCNUM\", \"IMPUESTOS_idimpuesto\", \"IMPUESTOS_base\", \"IMPUESTOS_factor\", \"IMPUESTOS_estarifaunitaria\", \"IMPUESTOS_valor\" from " + SCHEMA + ".\"IMPUESTOS\"";

                //using (connection = new SqlConnection(connectionString))
                //{
                //SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    return QueryResult(connectionString, queryString);
                }
                    catch (Exception ex)
                    {
                        CsvGeneratorLog.StoreLog($"{this.ToString()}_GetImpuestosData_query  {ex.Message}", EventLogEntryType.Error);
                        return null;
                    }
                //}
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_GetImpuestosData  {exp.Message}", EventLogEntryType.Error);
                return null;
            }
            finally
            {
 //               connection.Close();
            }
        }


        /// <summary>
        /// Funcion para traer el listado de los impuestos correspondientes a los documentos que se procesaran, 
        /// el orden de los campos puede varias pero no se puede cambiar el nombre ni disminuir la cantidad
        /// </summary>
        /// <returns> Devuelve una datatable. Columnas son los campos del query y cada fila es uno de los Impuestos </returns>
        public DataTable GetDatosExtraData()
        {
            try
            {
                string queryString = "SELECT \"DOCNUM\", \"RETENCIONES_idretencion\", \"RETENCIONES_base\", \"RETENCIONES_factor\", \"RETENCIONES_valor\", \"RETENCIONES_tipo\" FROM " + SCHEMA + ".\"DATOS_EXTRAS\"";

                //using (connection = new SqlConnection(connectionString))
                //{
                //SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    return QueryResult(connectionString, queryString);
                }
                    catch (Exception ex)
                    {
                        CsvGeneratorLog.StoreLog($"{this.ToString()}_GetDatosExtraData_query  {ex.Message}", EventLogEntryType.Error);
                        return null;
                    }
                //}
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_GetDatosExtraData  {exp.Message}", EventLogEntryType.Error);
                return null;
            }
            finally
            {
 //               connection.Close();
            }
        }


        /// <summary>
        /// Funcion para traer el listado de los anticipos correspondientes a los documentos que se procesaran, 
        /// el orden de los campos puede varias pero no se puede cambiar el nombre ni disminuir la cantidad
        /// </summary>
        /// <returns> Devuelve una datatable. Columnas son los campos del query y cada fila es uno de los Anticipos </returns>
        public DataTable GetItemsData()
        {
            try
            {
                /*string queryString = "select \"DOCNUM\", \"ITEMS_COD_idestandar\", \"ITEMS_COD_nombreestandar\", \"ITEMS_COD_codigo\", \"ITEMS_descripcion\", \"ITEMS_notas\", \"ITEMS_cantidad\", \"ITEMS_cantidadporempaque\", " +
                            "\"ITEMS_preciounitario\", \"ITEMS_unidaddemedida\", \"ITEMS_marca\", \"ITEMS_modelo\", \"ITEMS_codigovendedor\", \"ITEMS_subcodigovendedor\", \"ITEMS_idmandante\", \"ITEMS_regalo\", \"ITEMS_totalitem\", " +
                            "\"ITEMS_CARGO_idconcepto\", \"ITEMS_CARGO_escargo\", \"ITEMS_CARGO_descripcion\", \"ITEMS_CARGO_porcentaje\", \"ITEMS_CARGO_base\", \"ITEMS_CARGO_valor\", \"ITEMS_IMPUES_idimpuesto\", \"ITEMS_IMPUES_base\", " +
                            "\"ITEMS_IMPUES_factor\", \"ITEMS_IMPUES_estarifaunitaria\", \"ITEMS_IMPUES_valor\", \"ITEMS_DT_clave\", \"ITEMS_DT_valor\" from " + SCHEMA + ".\"ITEMS\"";
                */
                string queryString = "select \"DOCNUM\", \"ITEMS_COD_idestandar\", \"ITEMS_COD_nombreestandar\", \"ITEMS_COD_codigo\", \"ITEMS_descripcion\", \"ITEMS_notas\", \"ITEMS_cantidad\", \"ITEMS_cantidadporempaque\", " +
                            "\"ITEMS_preciounitario\", \"ITEMS_unidaddemedida\", \"ITEMS_marca\", \"ITEMS_modelo\", \"ITEMS_codigovendedor\", \"ITEMS_subcodigovendedor\", \"ITEMS_idmandante\", \"ITEMS_regalo\", \"ITEMS_totalitem\", \"ITEMS_fechacompra\", \"ITEMS_formageneraciontransmision\",  " +
                            "\"ITEMS_CARGO_idconcepto\", \"ITEMS_CARGO_escargo\", \"ITEMS_CARGO_descripcion\", \"ITEMS_CARGO_porcentaje\", \"ITEMS_CARGO_base\", \"ITEMS_CARGO_valor\", \"ITEMS_IMPUES_idimpuesto\", \"ITEMS_IMPUES_base\", " +
                            "\"ITEMS_IMPUES_factor\", \"ITEMS_IMPUES_estarifaunitaria\", \"ITEMS_IMPUES_valor\", \"ITEMS_DT_clave\", \"ITEMS_DT_valor\" from " + SCHEMA + ".\"ITEMS\"";
                //using (connection = new SqlConnection(connectionString))
                //{
                //SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    return QueryResult(connectionString, queryString);
                }
                    catch (Exception ex)
                    {
                        CsvGeneratorLog.StoreLog($"{this.ToString()}_GetItemsData_query  {ex.Message}", EventLogEntryType.Error);
                        return null;
                    }
                //}
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_GetItemsData  {exp.Message}", EventLogEntryType.Error);
                return null;
            }
            finally
            {
  //              connection.Close();
            }
        }

        /// <summary>
        /// Funcion para ejecutar query generico
        /// </summary>
        /// <param name="connection">Coneccion a la base de datos</param>
        /// <param name="queryString">Query a procesar</param>
        /// <returns> Devuelve una datatable con el resultado del query </returns>
        private DataTable QueryResult(string connection, string queryString)
        {
            HanaConnection hconn = new HanaConnection(connection);

            hconn.Open();

            //HanaDataAdapter da = new HanaDataAdapter(queryString, hconn);
            //CsvGeneratorLog.StoreLog($"Conexión : Conexión Realizada", EventLogEntryType.Error);
            HanaCommand hc = new HanaCommand(queryString, hconn);

            DataTable dt = new DataTable();
           // CsvGeneratorLog.StoreLog($"Conexión : Consulta Ejecutada", EventLogEntryType.Error);

            HanaDataReader hr = hc.ExecuteReader();
            //da.Fill(dt);
            dt.Load(hr);
            hr.Close();
            hconn.Close();
            return dt;
        }

        /// <summary>
        /// Funcion para insertar en la tabla de traza los documentos que se actualizaron 
        /// </summary>
        /// <param name="DocNum">Numero de documento a insertar</param>
        /// <param name="idDocumentoElectronico">Id del documento devuelto por el servicio web</param>
        /// <param name="cufe">valor Cufe a insertar en la tabla</param>
        /// <param name="qr_data">data devuelta por el servicio web</param>
        /// <returns> Void </returns>
        public void InsertSuccessData(string DocNum, string idDocumentoElectronico, string cufe, string qr_data)
        {
            try
            {
                string queryString = $"INSERT INTO " + SCHEMA + ".\"@FE_INFO\" (\"Code\", \"Name\", \"U_idDocElect\", \"U_CUFE\", \"U_QR_DATA\") VALUES ('"+DocNum+"', '"+DocNum+"', '"+idDocumentoElectronico+"', '"+cufe+"', '"+qr_data+"')";

                //using (connection = new SqlConnection(connectionString))
                //{
                // SqlCommand command = new SqlCommand(queryString, connection);
                HanaConnection hconn = new HanaConnection(connectionString);
                try
                    {
                    hconn.Open();
                    HanaCommand hc = new HanaCommand(queryString, hconn);
                    hc.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        CsvGeneratorLog.StoreLog($"{this.ToString()}_InsertSuccessData_query  {ex.Message}", EventLogEntryType.Error);
                     }
                //}
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_InsertSuccessData  {exp.Message}", EventLogEntryType.Error);
             }
            finally
            {
  //              connection.Close();
            }
        }
        //INSERTAR INFORMACIÓN TABLA INTERMEDIA DE LOS DOCUMENTOS RECHAZADOS POR EL PROVEEDOR TECNOLOGICO
        public void InsertFailData(string DocNum, string numDoc, string log, string estado)
        {
            try
            {
                string queryString = $"INSERT INTO " + SCHEMA + ".\"@SCL_FE_ESTADO\" (\"Code\", \"Name\",\"U_SCL_NumeroDoc\", \"U_SCL_FechaEnv\", \"U_SCL_LogDoc\", \"U_SCL_EstadoDoc\") VALUES ('" + DocNum + "', '" + DocNum + "','" + numDoc + "', '" + DateTime.Now.ToString("yyyyMMdd") + "','" + log + "', '" + estado + "')";

                //using (connection = new SqlConnection(connectionString))
                //{
                // SqlCommand command = new SqlCommand(queryString, connection);
                HanaConnection hconn = new HanaConnection(connectionString);
                try
                {
                    hconn.Open();
                    HanaCommand hc = new HanaCommand(queryString, hconn);
                    hc.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    CsvGeneratorLog.StoreLog($"{this.ToString()}_InsertFailData_query  {ex.Message}" + " DocNum " + DocNum, EventLogEntryType.Error);
                }
                //}
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_InsertFailData  {exp.Message}", EventLogEntryType.Error);
            }
            finally
            {
                //              connection.Close();
            }
        }

        //Consultar numeracióm
        public DataTable GetSeriesName(string DocNum)
        {
            try
            {
                string[] idNum = DocNum.Split('-');
                string id = idNum[0];

                string queryString = $"SELECT \"SeriesName\" FROM " + SCHEMA + ".\"NNM1\" WHERE \"Remark\" = '" + id + "'";

                //using (connection = new SqlConnection(connectionString))
                //{
                // SqlCommand command = new SqlCommand(queryString, connection);
                HanaConnection hconn = new HanaConnection(connectionString);
                try
                {
                    return QueryResult(connectionString, queryString);
                }
                catch (Exception ex)
                {
                    CsvGeneratorLog.StoreLog($"{this.ToString()}_GetSeriesName_query  {ex.Message}" + " DocNum " + DocNum, EventLogEntryType.Error);
                    return null;
                }
                //}
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_GetSeriesName  {exp.Message}", EventLogEntryType.Error);
                return null;
            }
            finally
            {
                //              connection.Close();
            }
        }
        //Este metodo elimina los registros con estado 'M' de la tabla Documento Devueltos
        public void DeleteRowsM()
        {
            try
            {
                string queryString = $"DELETE FROM " + SCHEMA + ".\"@SCL_FE_ESTADO\" WHERE \"U_SCL_EstadoDoc\" = 'M'";

                HanaConnection hconn = new HanaConnection(connectionString);
                try
                {
                    hconn.Open();
                    HanaCommand hc = new HanaCommand(queryString, hconn);
                    hc.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    CsvGeneratorLog.StoreLog($"{this.ToString()}_DeleteRowsM_query  {ex.Message}", EventLogEntryType.Error);
                }
                //}
            }
            catch (Exception exp)
            {
                CsvGeneratorLog.StoreLog($"{this.ToString()}_DeleteRowsM  {exp.Message}", EventLogEntryType.Error);
            }
            finally
            {
                //              connection.Close();
            }
        }
    }
}
