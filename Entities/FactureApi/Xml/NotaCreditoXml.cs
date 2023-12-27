﻿
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class NotaCredito
{

    private NotaCreditoCabecera cabeceraField;

    private NotaCreditoCliente clienteField;

    private object documentosAdicionalesReferenciaField;

    private NotaCreditoEmisor emisorField;

    private NotaCreditoExtensiones extensionesField;

    private NotaCreditoFacturasRelacionadas facturasRelacionadasField;

    private NotaCreditoLinea[] lineaField;

    private NotaCreditoImpuesto[] impuestosField;

    private NotaCreditoMediosDePago mediosDePagoField;

    private NotaCreditoNotificacion notificacionField;

    private NotaCreditoTotales totalesField;

    /// <remarks/>
    public NotaCreditoCabecera Cabecera
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
    public NotaCreditoCliente Cliente
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
    public object DocumentosAdicionalesReferencia
    {
        get
        {
            return this.documentosAdicionalesReferenciaField;
        }
        set
        {
            this.documentosAdicionalesReferenciaField = value;
        }
    }

    /// <remarks/>
    public NotaCreditoEmisor Emisor
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
    public NotaCreditoExtensiones Extensiones
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

    /// <remarks/>
    public NotaCreditoFacturasRelacionadas FacturasRelacionadas
    {
        get
        {
            return this.facturasRelacionadasField;
        }
        set
        {
            this.facturasRelacionadasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Linea")]
    public NotaCreditoLinea[] Linea
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
    [System.Xml.Serialization.XmlArrayItemAttribute("Impuesto", IsNullable = false)]
    public NotaCreditoImpuesto[] Impuestos
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
    public NotaCreditoMediosDePago MediosDePago
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
    public NotaCreditoNotificacion Notificacion
    {
        get
        {
            return this.notificacionField;
        }
        set
        {
            this.notificacionField = value;
        }
    }

    /// <remarks/>
    public NotaCreditoTotales Totales
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoCabecera
{

    private string fechaEmisionField;

    private string horaEmisionField;

    private string monedaNotaField;

    private string numeroField;

    private string observacionesField;

    private string prefijoField;

    private string vencimientoField;

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
    public string MonedaNota
    {
        get
        {
            return this.monedaNotaField;
        }
        set
        {
            this.monedaNotaField = value;
        }
    }

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
    public string Prefijo
    {
        get
        {
            return this.prefijoField;
        }
        set
        {
            this.prefijoField = value;
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
public partial class NotaCreditoCliente
{

    private NotaCreditoClienteDireccion direccionField;

    private NotaCreditoClienteDireccionFiscal direccionFiscalField;

    private NotaCreditoClienteObligacionesCliente obligacionesClienteField;

    private NotaCreditoClienteTributoCliente tributoClienteField;

    private string dvField;

    private string nombreComercialField;

    private string numeroIdentificacionField;

    private string razonSocialField;

    private string tipoIdentificacionField;

    private string tipoPersonaField;

    private string tipoRegimenField;

    /// <remarks/>
    public NotaCreditoClienteDireccion Direccion
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
    public NotaCreditoClienteDireccionFiscal DireccionFiscal
    {
        get
        {
            return this.direccionFiscalField;
        }
        set
        {
            this.direccionFiscalField = value;
        }
    }

    /// <remarks/>
    public NotaCreditoClienteObligacionesCliente ObligacionesCliente
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
    public NotaCreditoClienteTributoCliente TributoCliente
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
    public string NombreComercial
    {
        get
        {
            return this.nombreComercialField;
        }
        set
        {
            this.nombreComercialField = value;
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
    public string TipoRegimen
    {
        get
        {
            return this.tipoRegimenField;
        }
        set
        {
            this.tipoRegimenField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoClienteDireccion
{

    private string codigoDepartamentoField;

    private string codigoMunicipioField;

    private string codigoPaisField;

    private string codigoPostalField;

    private string direccionField;

    private string idiomaPaisField;

    private string nombreCiudadField;

    private string nombreDepartamentoField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoClienteDireccionFiscal
{

    private string codigoDepartamentoField;

    private string codigoMunicipioField;

    private string codigoPaisField;

    private string direccionField;

    private string idiomaPaisField;

    private string nombreCiudadField;

    private string nombreDepartamentoField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoClienteObligacionesCliente
{

    private string codigoObligacionField;

    /// <remarks/>
    public string CodigoObligacion
    {
        get
        {
            return this.codigoObligacionField;
        }
        set
        {
            this.codigoObligacionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoClienteTributoCliente
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
public partial class NotaCreditoEmisor
{

    private NotaCreditoEmisorContacto contactoField;

    private NotaCreditoEmisorDireccion direccionField;

    private NotaCreditoEmisorObligacionesEmisor obligacionesEmisorField;

    private NotaCreditoEmisorTributoEmisor tributoEmisorField;

    private string dvField;

    private string numeroIdentificacionField;

    private string razonSocialField;

    private string tipoIdentificacionField;

    private string tipoPersonaField;

    /// <remarks/>
    public NotaCreditoEmisorContacto Contacto
    {
        get
        {
            return this.contactoField;
        }
        set
        {
            this.contactoField = value;
        }
    }

    /// <remarks/>
    public NotaCreditoEmisorDireccion Direccion
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
    public NotaCreditoEmisorObligacionesEmisor ObligacionesEmisor
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
    public NotaCreditoEmisorTributoEmisor TributoEmisor
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoEmisorContacto
{

    private string emailField;

    private string nombreField;

    private string notasField;

    private string telefonoField;

    private string telfaxField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Notas
    {
        get
        {
            return this.notasField;
        }
        set
        {
            this.notasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Telefono
    {
        get
        {
            return this.telefonoField;
        }
        set
        {
            this.telefonoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Telfax
    {
        get
        {
            return this.telfaxField;
        }
        set
        {
            this.telfaxField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoEmisorDireccion
{

    private string codigoPaisField;

    private string direccionField;

    private string nombreCiudadField;

    private string nombreDepartamentoField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoEmisorObligacionesEmisor
{

    private string codigoObligacionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoObligacion
    {
        get
        {
            return this.codigoObligacionField;
        }
        set
        {
            this.codigoObligacionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoEmisorTributoEmisor
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
public partial class NotaCreditoExtensiones
{

    private NotaCreditoExtensionesCampoAdicional[] datosAdicionalesField;

    private object informacionAdicionalRowsField;

    private NotaCreditoExtensionesNumeracion numeracionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CampoAdicional", IsNullable = false)]
    public NotaCreditoExtensionesCampoAdicional[] DatosAdicionales
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

    /// <remarks/>
    public object InformacionAdicionalRows
    {
        get
        {
            return this.informacionAdicionalRowsField;
        }
        set
        {
            this.informacionAdicionalRowsField = value;
        }
    }

    /// <remarks/>
    public NotaCreditoExtensionesNumeracion Numeracion
    {
        get
        {
            return this.numeracionField;
        }
        set
        {
            this.numeracionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoExtensionesCampoAdicional
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
public partial class NotaCreditoExtensionesNumeracion
{

    private string numeroFinField;

    private string numeroInicioField;

    private string prefijoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumeroFin
    {
        get
        {
            return this.numeroFinField;
        }
        set
        {
            this.numeroFinField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumeroInicio
    {
        get
        {
            return this.numeroInicioField;
        }
        set
        {
            this.numeroInicioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Prefijo
    {
        get
        {
            return this.prefijoField;
        }
        set
        {
            this.prefijoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoFacturasRelacionadas
{

    private NotaCreditoFacturasRelacionadasFacturaRelacionada facturaRelacionadaField;

    /// <remarks/>
    public NotaCreditoFacturasRelacionadasFacturaRelacionada FacturaRelacionada
    {
        get
        {
            return this.facturaRelacionadaField;
        }
        set
        {
            this.facturaRelacionadaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoFacturasRelacionadasFacturaRelacionada
{

    private string cUFEField;

    private string numeroField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CUFE
    {
        get
        {
            return this.cUFEField;
        }
        set
        {
            this.cUFEField = value;
        }
    }

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoLinea
{

    private NotaCreditoLineaCodificacionVendedor codificacionVendedorField;

    private NotaCreditoLineaDetalle detalleField;

    private NotaCreditoLineaImpuestos impuestosField;

    private NotaCreditoLineaPrecioReferencia precioReferenciaField;

    /// <remarks/>
    public NotaCreditoLineaCodificacionVendedor CodificacionVendedor
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
    public NotaCreditoLineaDetalle Detalle
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
    public NotaCreditoLineaImpuestos Impuestos
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
    public NotaCreditoLineaPrecioReferencia PrecioReferencia
    {
        get
        {
            return this.precioReferenciaField;
        }
        set
        {
            this.precioReferenciaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoLineaCodificacionVendedor
{

    private string codigoArticuloField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoLineaDetalle
{

    private string cantidadField;

    private string cantidadBaseField;

    private string descripcionField;

    private string notaField;

    private string numeroLineaField;

    private string precioUnitarioField;

    private string subTotalLineaField;

    private string unidadMedidaField;

    private string valorTotalItemField;

    private string lField;

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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string l
    {
        get
        {
            return this.lField;
        }
        set
        {
            this.lField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoLineaImpuestos
{

    private NotaCreditoLineaImpuestosImpuesto impuestoField;

    /// <remarks/>
    public NotaCreditoLineaImpuestosImpuesto Impuesto
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
public partial class NotaCreditoLineaImpuestosImpuesto
{

    private NotaCreditoLineaImpuestosImpuestoSubtotal subtotalField;

    private string nombreField;

    private string redondeoField;

    private string tipoField;

    private string valorField;

    /// <remarks/>
    public NotaCreditoLineaImpuestosImpuestoSubtotal Subtotal
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
public partial class NotaCreditoLineaImpuestosImpuestoSubtotal
{

    private string codigoUnidadMedidaBaseField;

    private string porcentajeField;

    private string tipoField;

    private string valorField;

    private string valorBaseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoUnidadMedidaBase
    {
        get
        {
            return this.codigoUnidadMedidaBaseField;
        }
        set
        {
            this.codigoUnidadMedidaBaseField = value;
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
public partial class NotaCreditoLineaPrecioReferencia
{

    private string codigoTipoPrecioField;

    private string monedaPrecioReferenciaField;

    private string valorArticuloField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodigoTipoPrecio
    {
        get
        {
            return this.codigoTipoPrecioField;
        }
        set
        {
            this.codigoTipoPrecioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MonedaPrecioReferencia
    {
        get
        {
            return this.monedaPrecioReferenciaField;
        }
        set
        {
            this.monedaPrecioReferenciaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ValorArticulo
    {
        get
        {
            return this.valorArticuloField;
        }
        set
        {
            this.valorArticuloField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoImpuesto
{

    private NotaCreditoImpuestoSubtotal subtotalField;

    private string valorField;

    private string tipoField;

    private string nombreField;

    /// <remarks/>
    public NotaCreditoImpuestoSubtotal Subtotal
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
public partial class NotaCreditoImpuestoSubtotal
{

    private string valorBaseField;

    private string porcentajeField;

    private string valorField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoMediosDePago
{

    private string codigoMedioPagoField;

    private string formaDePagoField;

    private string vencimientoField;

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
public partial class NotaCreditoNotificacion
{

    private object[] paraField;

    private string deField;

    private string tipoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Para")]
    public object[] Para
    {
        get
        {
            return this.paraField;
        }
        set
        {
            this.paraField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string De
    {
        get
        {
            return this.deField;
        }
        set
        {
            this.deField = value;
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class NotaCreditoTotales
{

    private string anticipoField;

    private string baseImponibleField;

    private string brutoField;

    private string brutoMasImpuestosField;

    private string cargosField;

    private string descuentosField;

    private string generalField;

    private string impuestosField;

    private string redondeoField;

    private string retencionesField;

    private string totalIcaField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Anticipo
    {
        get
        {
            return this.anticipoField;
        }
        set
        {
            this.anticipoField = value;
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
    public string Retenciones
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalIca
    {
        get
        {
            return this.totalIcaField;
        }
        set
        {
            this.totalIcaField = value;
        }
    }
}

