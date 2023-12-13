using Log;
using Model.Query;
using Model.XmlModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
	public class DatosExtraGeneration : IDatosExtraGeneration
	{
		private readonly IDbQuery dbQuery;
		private readonly IEventLogStore CsvGeneratorLog;

		public DatosExtraGeneration(IDbQuery dbQuery, IEventLogStore csvGeneratorLog)
		{
			this.dbQuery = dbQuery;
			CsvGeneratorLog = csvGeneratorLog;
		}

		/// <summary>
		/// Genera un listado de objetos del tipo XmlImpuesto tomando como entrada la respuesta del query
		/// </summary>
		/// <returns> Devuelve un listado de objetos XmlImpuesto los cuales son los Impuestos asignados a los documentos a procesar  </returns>
		public List<XmlDatoExtra> GenerateDatosExtraList()
		{
			try
			{
				DataTable DatosExtraTable = dbQuery.GetDatosExtraData();
				return GenerateList(DatosExtraTable);
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Convierte la informacion de Impuestos en una dataTable en un listado de objetos 
		/// </summary>
		/// <param name="DatosExtraTable">Recibe una data table con la informacion de Impuestos</param>
		/// <returns> Devuelve un listado de objetos XmlImpuesto </returns>
		private List<XmlDatoExtra> GenerateList(DataTable DatosExtraTable)
		{
			try
			{
				//Se crea un nuevo objeto para almacenar la informacion
				List<XmlDatoExtra> DatosExtraList = new List<XmlDatoExtra>();

				if (DatosExtraTable != null)
				{
					XmlDatoExtra DatoExtra;

					foreach (DataRow drow in DatosExtraTable.Rows)
					{
						if (drow["RETENCIONES_valor"].ToString() != null)
						{
							/*XmlValor valor = new XmlValor();
							XmlColumnas columnas = new XmlColumnas();
							columnas.columna = drow["RETENCIONES_valor"].ToString();
							valor.columnas = columnas;
							*/
							string clv = drow["RETENCIONES_tipo"].ToString();

							//CsvGeneratorLog.StoreLog("Factura: " + drow["DOCNUM"].ToString() + " clave: " + clv + " valor: " + drow["RETENCIONES_valor"].ToString(), EventLogEntryType.Information);
							if (clv.Equals("0"))
							{
								clv = "AUTORETENCION";
							}
							if (clv.Equals("1"))
							{
								clv = "RETEFUENTE";
							}
							if (clv.Equals("3"))
							{
								clv = "RETEIVA";
							}
							if (clv.Equals("4"))
							{
								clv = "RTEICA";
							}
                            if (clv.Equals("9"))
                            {
                                clv = "CAJERO";
                            }
                            if (clv.Equals("10"))
                            {
                                clv = "SALDO_CAPITAL_ANTERIOR";
                            }
                            if (clv.Equals("11"))
                            {
                                clv = "ABONO_MORA";
                            }
                            if (clv.Equals("12"))
                            {
                                clv = "ABONO_CAPITAL";
                            }
                            if (clv.Equals("13"))
                            {
                                clv = "NUEVO_SALDO_CAPITAL";
                            }
                            //Se genera un objeto y se le asigna la informacion de una Retención

                            DatoExtra = new XmlDatoExtra()
							{
								DOCNUM = drow["DOCNUM"].ToString(),
								clave = clv,
								tipo = drow["RETENCIONES_idretencion"].ToString(),
								valor = drow["RETENCIONES_valor"].ToString()
							};

							//se agrega el impuesto al listado
							DatosExtraList.Add(DatoExtra);
						}
					}
				}

				return DatosExtraList;
			}
			catch (Exception exp)
			{
				CsvGeneratorLog.StoreLog($"{this.ToString()}_GenerateList  {exp.Message}", EventLogEntryType.Error);
				return null;
			}
		}
	}
}
