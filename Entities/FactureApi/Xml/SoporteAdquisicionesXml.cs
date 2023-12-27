
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class SoporteAdquisiciones
{

    private SoporteAdquisicionesCabecera cabeceraField;

    private string[] observacionesAdicionalesField;

    private SoporteAdquisicionesNumeracionDIAN numeracionDIANField;

    private SoporteAdquisicionesNASRelacionadasNASRelacionada[][] nASRelacionadasField;

    private SoporteAdquisicionesEmisor emisorField;

    private SoporteAdquisicionesCliente clienteField;

    private SoporteAdquisicionesMediosDePago mediosDePagoField;

    private SoporteAdquisicionesDescuentoOCargo[] descuentosOCargosField;

    private SoporteAdquisicionesTasaDeCambio tasaDeCambioField;

    private SoporteAdquisicionesTasaDeCambioAlterna tasaDeCambioAlternaField;

    private SoporteAdquisicionesImpuestos impuestosField;

    private SoporteAdquisicionesRetencion[] retencionesField;

    private SoporteAdquisicionesTotales totalesField;

    private SoporteAdquisicionesLinea lineaField;

    private SoporteAdquisicionesExtensiones extensionesField;

    /// <remarks/>
    public SoporteAdquisicionesCabecera Cabecera
    {
        get
        {
            return this.cabeceraField;
        }
        set
        {
            this.cabeceraField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Observaciones", IsNullable = false)]
    public string[] ObservacionesAdicionales
    {
        get
        {
            return this.observacionesAdicionalesField;
        }
        set
        {
            this.observacionesAdicionalesField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesNumeracionDIAN NumeracionDIAN
    {
        get
        {
            return this.numeracionDIANField;
        }
        set
        {
            this.numeracionDIANField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("NASRelacionada", typeof(SoporteAdquisicionesNASRelacionadasNASRelacionada), IsNullable = false)]
    public SoporteAdquisicionesNASRelacionadasNASRelacionada[][] NASRelacionadas
    {
        get
        {
            return this.nASRelacionadasField;
        }
        set
        {
            this.nASRelacionadasField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesEmisor Emisor
    {
        get
        {
            return this.emisorField;
        }
        set
        {
            this.emisorField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesCliente Cliente
    {
        get
        {
            return this.clienteField;
        }
        set
        {
            this.clienteField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesMediosDePago MediosDePago
    {
        get
        {
            return this.mediosDePagoField;
        }
        set
        {
            this.mediosDePagoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("DescuentoOCargo", IsNullable = false)]
    public SoporteAdquisicionesDescuentoOCargo[] DescuentosOCargos
    {
        get
        {
            return this.descuentosOCargosField;
        }
        set
        {
            this.descuentosOCargosField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesTasaDeCambio TasaDeCambio
    {
        get
        {
            return this.tasaDeCambioField;
        }
        set
        {
            this.tasaDeCambioField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesTasaDeCambioAlterna TasaDeCambioAlterna
    {
        get
        {
            return this.tasaDeCambioAlternaField;
        }
        set
        {
            this.tasaDeCambioAlternaField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesImpuestos Impuestos
    {
        get
        {
            return this.impuestosField;
        }
        set
        {
            this.impuestosField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
    public SoporteAdquisicionesRetencion[] Retenciones
    {
        get
        {
            return this.retencionesField;
        }
        set
        {
            this.retencionesField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesTotales Totales
    {
        get
        {
            return this.totalesField;
        }
        set
        {
            this.totalesField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesLinea Linea
    {
        get
        {
            return this.lineaField;
        }
        set
        {
            this.lineaField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesExtensiones Extensiones
    {
        get
        {
            return this.extensionesField;
        }
        set
        {
            this.extensionesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesCabecera
{

    private string numeroField;

    private string fechaEmisionField;

    private string horaEmisionField;

    private string vencimientoField;

    private string tipoOperacionField;

    private string tipoDocumentoSoporteField;

    private string observacionesField;

    private string monedaDocumentoSoporteField;

    private string ordenCompraField;

    private string fechaOrdenCompraField;

    private string lineasDeDocumentoSoporteField;

    private string ambienteField;

    private string nitFabricanteSoftwareField;

    private string razonSocialFabricanteSoftwareField;

    private string nombreSoftwareField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Numero
    {
        get
        {
            return this.numeroField;
        }
        set
        {
            this.numeroField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaEmision
    {
        get
        {
            return this.fechaEmisionField;
        }
        set
        {
            this.fechaEmisionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string HoraEmision
    {
        get
        {
            return this.horaEmisionField;
        }
        set
        {
            this.horaEmisionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Vencimiento
    {
        get
        {
            return this.vencimientoField;
        }
        set
        {
            this.vencimientoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoOperacion
    {
        get
        {
            return this.tipoOperacionField;
        }
        set
        {
            this.tipoOperacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoDocumentoSoporte
    {
        get
        {
            return this.tipoDocumentoSoporteField;
        }
        set
        {
            this.tipoDocumentoSoporteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Observaciones
    {
        get
        {
            return this.observacionesField;
        }
        set
        {
            this.observacionesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MonedaDocumentoSoporte
    {
        get
        {
            return this.monedaDocumentoSoporteField;
        }
        set
        {
            this.monedaDocumentoSoporteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OrdenCompra
    {
        get
        {
            return this.ordenCompraField;
        }
        set
        {
            this.ordenCompraField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaOrdenCompra
    {
        get
        {
            return this.fechaOrdenCompraField;
        }
        set
        {
            this.fechaOrdenCompraField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LineasDeDocumentoSoporte
    {
        get
        {
            return this.lineasDeDocumentoSoporteField;
        }
        set
        {
            this.lineasDeDocumentoSoporteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Ambiente
    {
        get
        {
            return this.ambienteField;
        }
        set
        {
            this.ambienteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NitFabricanteSoftware
    {
        get
        {
            return this.nitFabricanteSoftwareField;
        }
        set
        {
            this.nitFabricanteSoftwareField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RazonSocialFabricanteSoftware
    {
        get
        {
            return this.razonSocialFabricanteSoftwareField;
        }
        set
        {
            this.razonSocialFabricanteSoftwareField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NombreSoftware
    {
        get
        {
            return this.nombreSoftwareField;
        }
        set
        {
            this.nombreSoftwareField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesNumeracionDIAN
{

    private string numeroResolucionField;

    private string fechaInicioField;

    private string fechaFinField;

    private string prefijoNumeracionField;

    private string consecutivoInicialField;

    private string consecutivoFinalField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumeroResolucion
    {
        get
        {
            return this.numeroResolucionField;
        }
        set
        {
            this.numeroResolucionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaInicio
    {
        get
        {
            return this.fechaInicioField;
        }
        set
        {
            this.fechaInicioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaFin
    {
        get
        {
            return this.fechaFinField;
        }
        set
        {
            this.fechaFinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PrefijoNumeracion
    {
        get
        {
            return this.prefijoNumeracionField;
        }
        set
        {
            this.prefijoNumeracionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ConsecutivoInicial
    {
        get
        {
            return this.consecutivoInicialField;
        }
        set
        {
            this.consecutivoInicialField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ConsecutivoFinal
    {
        get
        {
            return this.consecutivoFinalField;
        }
        set
        {
            this.consecutivoFinalField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesNASRelacionadasNASRelacionada
{

    private string numeroField;

    private string cUDSField;

    private string fechaEmisionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Numero
    {
        get
        {
            return this.numeroField;
        }
        set
        {
            this.numeroField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CUDS
    {
        get
        {
            return this.cUDSField;
        }
        set
        {
            this.cUDSField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaEmision
    {
        get
        {
            return this.fechaEmisionField;
        }
        set
        {
            this.fechaEmisionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesEmisor
{

    private SoporteAdquisicionesEmisorDireccion direccionField;

    private string[] direccionesAdicionalesField;

    private string[] obligacionesEmisorField;

    private SoporteAdquisicionesEmisorTributoEmisor tributoEmisorField;

    private string tipoPersonaField;

    private string razonSocialField;

    private string numeroIdentificacionField;

    private string dvField;

    private string tipoIdentificacionField;

    /// <remarks/>
    public SoporteAdquisicionesEmisorDireccion Direccion
    {
        get
        {
            return this.direccionField;
        }
        set
        {
            this.direccionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Direccion", IsNullable = false)]
    public string[] DireccionesAdicionales
    {
        get
        {
            return this.direccionesAdicionalesField;
        }
        set
        {
            this.direccionesAdicionalesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CodigoObligacion", IsNullable = false)]
    public string[] ObligacionesEmisor
    {
        get
        {
            return this.obligacionesEmisorField;
        }
        set
        {
            this.obligacionesEmisorField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesEmisorTributoEmisor TributoEmisor
    {
        get
        {
            return this.tributoEmisorField;
        }
        set
        {
            this.tributoEmisorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoPersona
    {
        get
        {
            return this.tipoPersonaField;
        }
        set
        {
            this.tipoPersonaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RazonSocial
    {
        get
        {
            return this.razonSocialField;
        }
        set
        {
            this.razonSocialField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumeroIdentificacion
    {
        get
        {
            return this.numeroIdentificacionField;
        }
        set
        {
            this.numeroIdentificacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DV
    {
        get
        {
            return this.dvField;
        }
        set
        {
            this.dvField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoIdentificacion
    {
        get
        {
            return this.tipoIdentificacionField;
        }
        set
        {
            this.tipoIdentificacionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesEmisorDireccion
{

    private string codigoMunicipioField;

    private string nombreCiudadField;

    private string codigoPostalField;

    private string nombreDepartamentoField;

    private string codigoDepartamentoField;

    private string direccionField;

    private string codigoPaisField;

    private string nombrePaisField;

    private string idiomaPaisField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoMunicipio
    {
        get
        {
            return this.codigoMunicipioField;
        }
        set
        {
            this.codigoMunicipioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NombreCiudad
    {
        get
        {
            return this.nombreCiudadField;
        }
        set
        {
            this.nombreCiudadField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoPostal
    {
        get
        {
            return this.codigoPostalField;
        }
        set
        {
            this.codigoPostalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NombreDepartamento
    {
        get
        {
            return this.nombreDepartamentoField;
        }
        set
        {
            this.nombreDepartamentoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoDepartamento
    {
        get
        {
            return this.codigoDepartamentoField;
        }
        set
        {
            this.codigoDepartamentoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Direccion
    {
        get
        {
            return this.direccionField;
        }
        set
        {
            this.direccionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoPais
    {
        get
        {
            return this.codigoPaisField;
        }
        set
        {
            this.codigoPaisField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NombrePais
    {
        get
        {
            return this.nombrePaisField;
        }
        set
        {
            this.nombrePaisField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IdiomaPais
    {
        get
        {
            return this.idiomaPaisField;
        }
        set
        {
            this.idiomaPaisField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesEmisorTributoEmisor
{

    private string codigoTributoField;

    private string nombreTributoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoTributo
    {
        get
        {
            return this.codigoTributoField;
        }
        set
        {
            this.codigoTributoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NombreTributo
    {
        get
        {
            return this.nombreTributoField;
        }
        set
        {
            this.nombreTributoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesCliente
{

    private object[] obligacionesClienteField;

    private SoporteAdquisicionesClienteTributoCliente tributoClienteField;

    private string tipoPersonaField;

    private string razonSocialField;

    private string numeroIdentificacionField;

    private string dvField;

    private string tipoIdentificacionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CodigoObligacion", IsNullable = false)]
    public object[] ObligacionesCliente
    {
        get
        {
            return this.obligacionesClienteField;
        }
        set
        {
            this.obligacionesClienteField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesClienteTributoCliente TributoCliente
    {
        get
        {
            return this.tributoClienteField;
        }
        set
        {
            this.tributoClienteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoPersona
    {
        get
        {
            return this.tipoPersonaField;
        }
        set
        {
            this.tipoPersonaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RazonSocial
    {
        get
        {
            return this.razonSocialField;
        }
        set
        {
            this.razonSocialField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumeroIdentificacion
    {
        get
        {
            return this.numeroIdentificacionField;
        }
        set
        {
            this.numeroIdentificacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DV
    {
        get
        {
            return this.dvField;
        }
        set
        {
            this.dvField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoIdentificacion
    {
        get
        {
            return this.tipoIdentificacionField;
        }
        set
        {
            this.tipoIdentificacionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesClienteTributoCliente
{

    private string codigoTributoField;

    private string nombreTributoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoTributo
    {
        get
        {
            return this.codigoTributoField;
        }
        set
        {
            this.codigoTributoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NombreTributo
    {
        get
        {
            return this.nombreTributoField;
        }
        set
        {
            this.nombreTributoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesMediosDePago
{

    private string[] identificadorPagoField;

    private string codigoMedioPagoField;

    private string formaDePagoField;

    private string vencimientoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ReferenciaPago", IsNullable = false)]
    public string[] IdentificadorPago
    {
        get
        {
            return this.identificadorPagoField;
        }
        set
        {
            this.identificadorPagoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoMedioPago
    {
        get
        {
            return this.codigoMedioPagoField;
        }
        set
        {
            this.codigoMedioPagoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FormaDePago
    {
        get
        {
            return this.formaDePagoField;
        }
        set
        {
            this.formaDePagoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Vencimiento
    {
        get
        {
            return this.vencimientoField;
        }
        set
        {
            this.vencimientoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesDescuentoOCargo
{

    private string idField;

    private string indicadorField;

    private string codigoDescuentoField;

    private string justificacionField;

    private string porcentajeField;

    private string valorField;

    private string valorBaseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Indicador
    {
        get
        {
            return this.indicadorField;
        }
        set
        {
            this.indicadorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoDescuento
    {
        get
        {
            return this.codigoDescuentoField;
        }
        set
        {
            this.codigoDescuentoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Justificacion
    {
        get
        {
            return this.justificacionField;
        }
        set
        {
            this.justificacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Porcentaje
    {
        get
        {
            return this.porcentajeField;
        }
        set
        {
            this.porcentajeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValorBase
    {
        get
        {
            return this.valorBaseField;
        }
        set
        {
            this.valorBaseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesTasaDeCambio
{

    private string monedaDestinoField;

    private string valorTasaDeCambioField;

    private string fechaTasaDeCambioField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MonedaDestino
    {
        get
        {
            return this.monedaDestinoField;
        }
        set
        {
            this.monedaDestinoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValorTasaDeCambio
    {
        get
        {
            return this.valorTasaDeCambioField;
        }
        set
        {
            this.valorTasaDeCambioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaTasaDeCambio
    {
        get
        {
            return this.fechaTasaDeCambioField;
        }
        set
        {
            this.fechaTasaDeCambioField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesTasaDeCambioAlterna
{

    private string monedaOrigenField;

    private string monedaDestinoField;

    private string valorTasaDeCambioField;

    private string fechaTasaCambioAlternaField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MonedaOrigen
    {
        get
        {
            return this.monedaOrigenField;
        }
        set
        {
            this.monedaOrigenField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MonedaDestino
    {
        get
        {
            return this.monedaDestinoField;
        }
        set
        {
            this.monedaDestinoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValorTasaDeCambio
    {
        get
        {
            return this.valorTasaDeCambioField;
        }
        set
        {
            this.valorTasaDeCambioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaTasaCambioAlterna
    {
        get
        {
            return this.fechaTasaCambioAlternaField;
        }
        set
        {
            this.fechaTasaCambioAlternaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesImpuestos
{

    private SoporteAdquisicionesImpuestosImpuesto impuestoField;

    /// <remarks/>
    public SoporteAdquisicionesImpuestosImpuesto Impuesto
    {
        get
        {
            return this.impuestoField;
        }
        set
        {
            this.impuestoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesImpuestosImpuesto
{

    private SoporteAdquisicionesImpuestosImpuestoSubtotal subtotalField;

    private string valorField;

    private string tipoField;

    private string nombreField;

    /// <remarks/>
    public SoporteAdquisicionesImpuestosImpuestoSubtotal Subtotal
    {
        get
        {
            return this.subtotalField;
        }
        set
        {
            this.subtotalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Tipo
    {
        get
        {
            return this.tipoField;
        }
        set
        {
            this.tipoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesImpuestosImpuestoSubtotal
{

    private string valorBaseField;

    private string valorField;

    private string porcentajeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValorBase
    {
        get
        {
            return this.valorBaseField;
        }
        set
        {
            this.valorBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Porcentaje
    {
        get
        {
            return this.porcentajeField;
        }
        set
        {
            this.porcentajeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesRetencion
{

    private SoporteAdquisicionesRetencionSubtotal subtotalField;

    private string valorField;

    private string tipoField;

    private string nombreField;

    /// <remarks/>
    public SoporteAdquisicionesRetencionSubtotal Subtotal
    {
        get
        {
            return this.subtotalField;
        }
        set
        {
            this.subtotalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Tipo
    {
        get
        {
            return this.tipoField;
        }
        set
        {
            this.tipoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesRetencionSubtotal
{

    private string valorBaseField;

    private string valorField;

    private string porcentajeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValorBase
    {
        get
        {
            return this.valorBaseField;
        }
        set
        {
            this.valorBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Porcentaje
    {
        get
        {
            return this.porcentajeField;
        }
        set
        {
            this.porcentajeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesTotales
{

    private string brutoField;

    private string baseImponibleField;

    private string brutoMasImpuestosField;

    private string cargosField;

    private string descuentosField;

    private string impuestosField;

    private string generalField;

    private string redondeoField;

    private string totalDescuentosLineasField;

    private string totalCargosLineasField;

    private string totalOtros1Field;

    private string totalOtros2Field;

    private string totalReteFuenteField;

    private string totalReteIvaField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Bruto
    {
        get
        {
            return this.brutoField;
        }
        set
        {
            this.brutoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BaseImponible
    {
        get
        {
            return this.baseImponibleField;
        }
        set
        {
            this.baseImponibleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BrutoMasImpuestos
    {
        get
        {
            return this.brutoMasImpuestosField;
        }
        set
        {
            this.brutoMasImpuestosField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Cargos
    {
        get
        {
            return this.cargosField;
        }
        set
        {
            this.cargosField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Descuentos
    {
        get
        {
            return this.descuentosField;
        }
        set
        {
            this.descuentosField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impuestos
    {
        get
        {
            return this.impuestosField;
        }
        set
        {
            this.impuestosField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string General
    {
        get
        {
            return this.generalField;
        }
        set
        {
            this.generalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Redondeo
    {
        get
        {
            return this.redondeoField;
        }
        set
        {
            this.redondeoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalDescuentosLineas
    {
        get
        {
            return this.totalDescuentosLineasField;
        }
        set
        {
            this.totalDescuentosLineasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalCargosLineas
    {
        get
        {
            return this.totalCargosLineasField;
        }
        set
        {
            this.totalCargosLineasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalOtros1
    {
        get
        {
            return this.totalOtros1Field;
        }
        set
        {
            this.totalOtros1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalOtros2
    {
        get
        {
            return this.totalOtros2Field;
        }
        set
        {
            this.totalOtros2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalReteFuente
    {
        get
        {
            return this.totalReteFuenteField;
        }
        set
        {
            this.totalReteFuenteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalReteIva
    {
        get
        {
            return this.totalReteIvaField;
        }
        set
        {
            this.totalReteIvaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLinea
{

    private SoporteAdquisicionesLineaDetalle detalleField;

    private string[] notasAdicionalesField;

    private SoporteAdquisicionesLineaDescuentoOCargo[] descuentosOCargosField;

    private SoporteAdquisicionesLineaImpuestos impuestosField;

    private SoporteAdquisicionesLineaRetencion[] retencionesField;

    private SoporteAdquisicionesLineaCodificacionVendedor codificacionVendedorField;

    private SoporteAdquisicionesLineaCodificacionesEstandar codificacionesEstandarField;

    private SoporteAdquisicionesLineaCampoAdicional[] datosAdicionalesField;

    /// <remarks/>
    public SoporteAdquisicionesLineaDetalle Detalle
    {
        get
        {
            return this.detalleField;
        }
        set
        {
            this.detalleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Nota", IsNullable = false)]
    public string[] NotasAdicionales
    {
        get
        {
            return this.notasAdicionalesField;
        }
        set
        {
            this.notasAdicionalesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("DescuentoOCargo", IsNullable = false)]
    public SoporteAdquisicionesLineaDescuentoOCargo[] DescuentosOCargos
    {
        get
        {
            return this.descuentosOCargosField;
        }
        set
        {
            this.descuentosOCargosField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesLineaImpuestos Impuestos
    {
        get
        {
            return this.impuestosField;
        }
        set
        {
            this.impuestosField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
    public SoporteAdquisicionesLineaRetencion[] Retenciones
    {
        get
        {
            return this.retencionesField;
        }
        set
        {
            this.retencionesField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesLineaCodificacionVendedor CodificacionVendedor
    {
        get
        {
            return this.codificacionVendedorField;
        }
        set
        {
            this.codificacionVendedorField = value;
        }
    }

    /// <remarks/>
    public SoporteAdquisicionesLineaCodificacionesEstandar CodificacionesEstandar
    {
        get
        {
            return this.codificacionesEstandarField;
        }
        set
        {
            this.codificacionesEstandarField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CampoAdicional", IsNullable = false)]
    public SoporteAdquisicionesLineaCampoAdicional[] DatosAdicionales
    {
        get
        {
            return this.datosAdicionalesField;
        }
        set
        {
            this.datosAdicionalesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaDetalle
{

    private string numeroLineaField;

    private string notaField;

    private string cantidadField;

    private string unidadMedidaField;

    private string subTotalLineaField;

    private string fechaCompraField;

    private string codigoFormaGeneracionTransmisionField;

    private string descripcionFormaGeneracionTransmisionField;

    private string descripcionField;

    private string cantidadXEmpaqueField;

    private string marcaField;

    private string nombreModeloField;

    private string cantidadBaseField;

    private string unidadCantidadBaseField;

    private string precioUnitarioField;

    private string valorTotalItemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumeroLinea
    {
        get
        {
            return this.numeroLineaField;
        }
        set
        {
            this.numeroLineaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nota
    {
        get
        {
            return this.notaField;
        }
        set
        {
            this.notaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Cantidad
    {
        get
        {
            return this.cantidadField;
        }
        set
        {
            this.cantidadField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UnidadMedida
    {
        get
        {
            return this.unidadMedidaField;
        }
        set
        {
            this.unidadMedidaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SubTotalLinea
    {
        get
        {
            return this.subTotalLineaField;
        }
        set
        {
            this.subTotalLineaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FechaCompra
    {
        get
        {
            return this.fechaCompraField;
        }
        set
        {
            this.fechaCompraField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoFormaGeneracionTransmision
    {
        get
        {
            return this.codigoFormaGeneracionTransmisionField;
        }
        set
        {
            this.codigoFormaGeneracionTransmisionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DescripcionFormaGeneracionTransmision
    {
        get
        {
            return this.descripcionFormaGeneracionTransmisionField;
        }
        set
        {
            this.descripcionFormaGeneracionTransmisionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Descripcion
    {
        get
        {
            return this.descripcionField;
        }
        set
        {
            this.descripcionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CantidadXEmpaque
    {
        get
        {
            return this.cantidadXEmpaqueField;
        }
        set
        {
            this.cantidadXEmpaqueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Marca
    {
        get
        {
            return this.marcaField;
        }
        set
        {
            this.marcaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NombreModelo
    {
        get
        {
            return this.nombreModeloField;
        }
        set
        {
            this.nombreModeloField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CantidadBase
    {
        get
        {
            return this.cantidadBaseField;
        }
        set
        {
            this.cantidadBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UnidadCantidadBase
    {
        get
        {
            return this.unidadCantidadBaseField;
        }
        set
        {
            this.unidadCantidadBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PrecioUnitario
    {
        get
        {
            return this.precioUnitarioField;
        }
        set
        {
            this.precioUnitarioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValorTotalItem
    {
        get
        {
            return this.valorTotalItemField;
        }
        set
        {
            this.valorTotalItemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaDescuentoOCargo
{

    private string idField;

    private string indicadorField;

    private string justificacionField;

    private string porcentajeField;

    private string valorField;

    private string valorBaseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Indicador
    {
        get
        {
            return this.indicadorField;
        }
        set
        {
            this.indicadorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Justificacion
    {
        get
        {
            return this.justificacionField;
        }
        set
        {
            this.justificacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Porcentaje
    {
        get
        {
            return this.porcentajeField;
        }
        set
        {
            this.porcentajeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValorBase
    {
        get
        {
            return this.valorBaseField;
        }
        set
        {
            this.valorBaseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaImpuestos
{

    private SoporteAdquisicionesLineaImpuestosImpuesto impuestoField;

    /// <remarks/>
    public SoporteAdquisicionesLineaImpuestosImpuesto Impuesto
    {
        get
        {
            return this.impuestoField;
        }
        set
        {
            this.impuestoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaImpuestosImpuesto
{

    private SoporteAdquisicionesLineaImpuestosImpuestoSubtotal subtotalField;

    private string valorField;

    private string tipoField;

    private string nombreField;

    /// <remarks/>
    public SoporteAdquisicionesLineaImpuestosImpuestoSubtotal Subtotal
    {
        get
        {
            return this.subtotalField;
        }
        set
        {
            this.subtotalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Tipo
    {
        get
        {
            return this.tipoField;
        }
        set
        {
            this.tipoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaImpuestosImpuestoSubtotal
{

    private string valorBaseField;

    private string valorField;

    private string porcentajeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValorBase
    {
        get
        {
            return this.valorBaseField;
        }
        set
        {
            this.valorBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Porcentaje
    {
        get
        {
            return this.porcentajeField;
        }
        set
        {
            this.porcentajeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaRetencion
{

    private SoporteAdquisicionesLineaRetencionSubtotal subtotalField;

    private string valorField;

    private string tipoField;

    private string nombreField;

    /// <remarks/>
    public SoporteAdquisicionesLineaRetencionSubtotal Subtotal
    {
        get
        {
            return this.subtotalField;
        }
        set
        {
            this.subtotalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Tipo
    {
        get
        {
            return this.tipoField;
        }
        set
        {
            this.tipoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaRetencionSubtotal
{

    private string valorBaseField;

    private string valorField;

    private string porcentajeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValorBase
    {
        get
        {
            return this.valorBaseField;
        }
        set
        {
            this.valorBaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Porcentaje
    {
        get
        {
            return this.porcentajeField;
        }
        set
        {
            this.porcentajeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaCodificacionVendedor
{

    private string codigoArticuloField;

    private string codigoExtendidoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoArticulo
    {
        get
        {
            return this.codigoArticuloField;
        }
        set
        {
            this.codigoArticuloField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoExtendido
    {
        get
        {
            return this.codigoExtendidoField;
        }
        set
        {
            this.codigoExtendidoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaCodificacionesEstandar
{

    private SoporteAdquisicionesLineaCodificacionesEstandarCodificacionEstandar codificacionEstandarField;

    /// <remarks/>
    public SoporteAdquisicionesLineaCodificacionesEstandarCodificacionEstandar CodificacionEstandar
    {
        get
        {
            return this.codificacionEstandarField;
        }
        set
        {
            this.codificacionEstandarField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaCodificacionesEstandarCodificacionEstandar
{

    private string codigoArticuloField;

    private string codigoEstandarField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoArticulo
    {
        get
        {
            return this.codigoArticuloField;
        }
        set
        {
            this.codigoArticuloField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoEstandar
    {
        get
        {
            return this.codigoEstandarField;
        }
        set
        {
            this.codigoEstandarField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesLineaCampoAdicional
{

    private string nombreField;

    private string valorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesExtensiones
{

    private SoporteAdquisicionesExtensionesInteroperabilidad interoperabilidadField;

    /// <remarks/>
    public SoporteAdquisicionesExtensionesInteroperabilidad Interoperabilidad
    {
        get
        {
            return this.interoperabilidadField;
        }
        set
        {
            this.interoperabilidadField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesExtensionesInteroperabilidad
{

    private SoporteAdquisicionesExtensionesInteroperabilidadGrupo grupoField;

    private string uRLAdjuntoField;

    /// <remarks/>
    public SoporteAdquisicionesExtensionesInteroperabilidadGrupo Grupo
    {
        get
        {
            return this.grupoField;
        }
        set
        {
            this.grupoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string URLAdjunto
    {
        get
        {
            return this.uRLAdjuntoField;
        }
        set
        {
            this.uRLAdjuntoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesExtensionesInteroperabilidadGrupo
{

    private SoporteAdquisicionesExtensionesInteroperabilidadGrupoCategoria categoriaField;

    private string nombreField;

    /// <remarks/>
    public SoporteAdquisicionesExtensionesInteroperabilidadGrupoCategoria Categoria
    {
        get
        {
            return this.categoriaField;
        }
        set
        {
            this.categoriaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesExtensionesInteroperabilidadGrupoCategoria
{

    private SoporteAdquisicionesExtensionesInteroperabilidadGrupoCategoriaCampoAdicional[] campoAdicionalField;

    private string nombreField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CampoAdicional")]
    public SoporteAdquisicionesExtensionesInteroperabilidadGrupoCategoriaCampoAdicional[] CampoAdicional
    {
        get
        {
            return this.campoAdicionalField;
        }
        set
        {
            this.campoAdicionalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SoporteAdquisicionesExtensionesInteroperabilidadGrupoCategoriaCampoAdicional
{

    private string nombreField;

    private string valorField;

    private string nombreEsquemaField;

    private string iDEsquemaField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Valor
    {
        get
        {
            return this.valorField;
        }
        set
        {
            this.valorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NombreEsquema
    {
        get
        {
            return this.nombreEsquemaField;
        }
        set
        {
            this.nombreEsquemaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IDEsquema
    {
        get
        {
            return this.iDEsquemaField;
        }
        set
        {
            this.iDEsquemaField = value;
        }
    }
}

