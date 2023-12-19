
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Factura
{

    private FacturaNumeracionDIAN numeracionDIANField;

    private FacturaNotificacion notificacionField;

    private FacturaEmisor emisorField;

    private FacturaCliente clienteField;

    private FacturaLinea[] lineaField;

    private FacturaRetenciones retencionesField;

    private FacturaTotales totalesField;

    private FacturaExtensiones extensionesField;

    private object documentosAdicionalesReferenciaField;

    private FacturaMediosDePago mediosDePagoField;

    private FacturaCabecera cabeceraField;

    /// <remarks/>
    public FacturaNumeracionDIAN NumeracionDIAN
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
    public FacturaNotificacion Notificacion
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
    public FacturaEmisor Emisor
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
    public FacturaCliente Cliente
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
    [System.Xml.Serialization.XmlElementAttribute("Linea")]
    public FacturaLinea[] Linea
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
    public FacturaRetenciones Retenciones
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
    public FacturaTotales Totales
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
    public FacturaExtensiones Extensiones
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
    public FacturaMediosDePago MediosDePago
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
    public FacturaCabecera Cabecera
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaNumeracionDIAN
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
public partial class FacturaNotificacion
{

    private string paraField;

    private string tipoField;

    private string deField;

    /// <remarks/>
    public string Para
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaEmisor
{

    private FacturaEmisorObligacionesEmisor obligacionesEmisorField;

    private FacturaEmisorTributoEmisor tributoEmisorField;

    private FacturaEmisorContacto contactoField;

    private string tipoPersonaField;

    private string razonSocialField;

    private string tipoIdentificacionField;

    private string numeroIdentificacionField;

    private string dvField;

    /// <remarks/>
    public FacturaEmisorObligacionesEmisor ObligacionesEmisor
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
    public FacturaEmisorTributoEmisor TributoEmisor
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
    public FacturaEmisorContacto Contacto
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaEmisorObligacionesEmisor
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
public partial class FacturaEmisorTributoEmisor
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
public partial class FacturaEmisorContacto
{

    private string nombreField;

    private string telefonoField;

    private string telfaxField;

    private string emailField;

    private string notasField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaCliente
{

    private FacturaClienteDireccion direccionField;

    private FacturaClienteDireccionFiscal direccionFiscalField;

    private FacturaClienteTributoCliente tributoClienteField;

    private FacturaClienteObligacionesCliente obligacionesClienteField;

    private string nombreComercialField;

    private string razonSocialField;

    private string tipoPersonaField;

    private string tipoRegimenField;

    private string tipoIdentificacionField;

    private string numeroIdentificacionField;

    private string dvField;

    /// <remarks/>
    public FacturaClienteDireccion Direccion
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
    public FacturaClienteDireccionFiscal DireccionFiscal
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
    public FacturaClienteTributoCliente TributoCliente
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
    public FacturaClienteObligacionesCliente ObligacionesCliente
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaClienteDireccion
{

    private string codigoMunicipioField;

    private string idiomaPaisField;

    private string codigoPaisField;

    private string nombreCiudadField;

    private string codigoPostalField;

    private string nombreDepartamentoField;

    private string codigoDepartamentoField;

    private string direccionField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaClienteDireccionFiscal
{

    private string codigoMunicipioField;

    private string codigoPaisField;

    private string nombreCiudadField;

    private string idiomaPaisField;

    private string nombreDepartamentoField;

    private string codigoDepartamentoField;

    private string direccionField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaClienteTributoCliente
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
public partial class FacturaClienteObligacionesCliente
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
public partial class FacturaLinea
{

    private FacturaLineaDetalle detalleField;

    private FacturaLineaPrecioReferencia precioReferenciaField;

    private FacturaLineaImpuestos impuestosField;

    private FacturaLineaCodificacionVendedor codificacionVendedorField;

    /// <remarks/>
    public FacturaLineaDetalle Detalle
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
    public FacturaLineaPrecioReferencia PrecioReferencia
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

    /// <remarks/>
    public FacturaLineaImpuestos Impuestos
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
    public FacturaLineaCodificacionVendedor CodificacionVendedor
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaLineaDetalle
{

    private string numeroLineaField;

    private string notaField;

    private string cantidadField;

    private string unidadMedidaField;

    private string subTotalLineaField;

    private string descripcionField;

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
public partial class FacturaLineaPrecioReferencia
{

    private string codigoTipoPrecioField;

    private string valorArticuloField;

    private string monedaPrecioReferenciaField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaLineaImpuestos
{

    private FacturaLineaImpuestosImpuesto impuestoField;

    /// <remarks/>
    public FacturaLineaImpuestosImpuesto Impuesto
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
public partial class FacturaLineaImpuestosImpuesto
{

    private FacturaLineaImpuestosImpuestoSubtotal subtotalField;

    private string valorField;

    private string tipoField;

    private string nombreField;

    private string redondeoField;

    /// <remarks/>
    public FacturaLineaImpuestosImpuestoSubtotal Subtotal
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaLineaImpuestosImpuestoSubtotal
{

    private string tipoField;

    private string valorBaseField;

    private string porcentajeField;

    private string valorField;

    private string codigoUnidadMedidaBaseField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaLineaCodificacionVendedor
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
public partial class FacturaRetenciones
{

    private FacturaRetencionesRetencion retencionField;

    /// <remarks/>
    public FacturaRetencionesRetencion Retencion
    {
        get
        {
            return this.retencionField;
        }
        set
        {
            this.retencionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaRetencionesRetencion
{

    private FacturaRetencionesRetencionSubtotal subtotalField;

    private string valorField;

    private string tipoField;

    private string nombreField;

    /// <remarks/>
    public FacturaRetencionesRetencionSubtotal Subtotal
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
public partial class FacturaRetencionesRetencionSubtotal
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
public partial class FacturaTotales
{

    private string brutoField;

    private string baseImponibleField;

    private string impuestosField;

    private string redondeoField;

    private string descuentosField;

    private string retencionesField;

    private string cargosField;

    private string anticipoField;

    private string totalIcaField;

    private string brutoMasImpuestosField;

    private string generalField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaExtensiones
{

    private FacturaExtensionesCampoAdicional[] datosAdicionalesField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CampoAdicional", IsNullable = false)]
    public FacturaExtensionesCampoAdicional[] DatosAdicionales
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
public partial class FacturaExtensionesCampoAdicional
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
public partial class FacturaMediosDePago
{

    private string codigoMedioPagoField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FacturaCabecera
{

    private string numeroField;

    private string fechaEmisionField;

    private string vencimientoField;

    private string horaEmisionField;

    private string observacionesField;

    private string tipoFacturaField;

    private string formaDePagoField;

    private string tipoOperacionField;

    private string monedaFacturaField;

    private string formatoContingenciaField;

    private string lineasDeFacturaField;

    private string ordenCompraField;

    private string ambienteField;

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
    public string TipoFactura
    {
        get
        {
            return this.tipoFacturaField;
        }
        set
        {
            this.tipoFacturaField = value;
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
    public string MonedaFactura
    {
        get
        {
            return this.monedaFacturaField;
        }
        set
        {
            this.monedaFacturaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FormatoContingencia
    {
        get
        {
            return this.formatoContingenciaField;
        }
        set
        {
            this.formatoContingenciaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LineasDeFactura
    {
        get
        {
            return this.lineasDeFacturaField;
        }
        set
        {
            this.lineasDeFacturaField = value;
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
}

