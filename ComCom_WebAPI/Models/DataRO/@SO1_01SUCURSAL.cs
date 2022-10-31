using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SUCURSAL
    {
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public int DocEntry { get; set; }
        public string? Canceled { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public int? UserSign { get; set; }
        public string? Transfered { get; set; }
        public DateTime? CreateDate { get; set; }
        public short? CreateTime { get; set; }
        public DateTime? UpdateDate { get; set; }
        public short? UpdateTime { get; set; }
        public string? DataSource { get; set; }
        public string? U_SO1_CENTROCOSTO { get; set; }
        public string U_SO1_TIEMPESPRES { get; set; } = null!;
        public string? U_SO1_NCENTROCOSTO { get; set; }
        public string U_SO1_MANEJOAUTDEVOL { get; set; } = null!;
        public short? U_SO1_SERIECOTIZA { get; set; }
        public string? U_SO1_CLIENTEMOS { get; set; }
        public string? U_SO1_NCLIENTEMOS { get; set; }
        public string? U_SO1_PREFFACTURA1 { get; set; }
        public string? U_SO1_PREFFACTURA2 { get; set; }
        public string? U_SO1_PREFFACTURA3 { get; set; }
        public string? U_SO1_PREFFACTURA4 { get; set; }
        public string? U_SO1_PREFFACTURA5 { get; set; }
        public string? U_SO1_SERVIDORBD { get; set; }
        public string? U_SO1_USUARIOBD { get; set; }
        public string? U_SO1_CONTRASENABD { get; set; }
        public string U_SO1_CONEXIONCONF { get; set; } = null!;
        public short? U_SO1_SERIEENTREGA { get; set; }
        public short? U_SO1_SERIEDEVOL { get; set; }
        public short? U_SO1_SERIEFACTURA { get; set; }
        public short? U_SO1_SERIEREFACTURA { get; set; }
        public short? U_SO1_SERIEFACDEVOL { get; set; }
        public short? U_SO1_SERIEFACPEDIDO { get; set; }
        public short? U_SO1_SERIENOTACRED { get; set; }
        public short? U_SO1_SERIEPAGOREC { get; set; }
        public short? U_SO1_SERIEPAGOEFE { get; set; }
        public short? U_SO1_SERIEFACGLOBAL { get; set; }
        public short? U_SO1_SERIENCGLOBAL { get; set; }
        public short? U_SO1_SERIECREDITO { get; set; }
        public short? U_SO1_SERIETRASPASO { get; set; }
        public short? U_SO1_SERIEORDENV { get; set; }
        public short? U_SO1_SERIESOLICITUD { get; set; }
        public short? U_SO1_SERIEENTRADAPR { get; set; }
        public short? U_SO1_SERIENOTACARGO { get; set; }
        public short? U_SO1_SUCURSALSBO { get; set; }
        public short? U_SO1_VIGENCIADEVOL { get; set; }
        public short? U_SO1_VIGENCIAFACTU { get; set; }
        public short? U_SO1_VIGENCIACOTI { get; set; }
        public short? U_SO1_VIGENCIAMOSTRA { get; set; }
        public int? U_SO1_FOLIOFACTURA1 { get; set; }
        public int? U_SO1_FOLIOFACTURA2 { get; set; }
        public int? U_SO1_FOLIOFACTURA3 { get; set; }
        public int? U_SO1_FOLIOFACTURA4 { get; set; }
        public int? U_SO1_FOLIOFACTURA5 { get; set; }
        public int? U_SO1_FOLIOMOSTRADOR { get; set; }
        public int? U_SO1_FOLIOCAJA { get; set; }
        public int? U_SO1_FOLIOCREDITO { get; set; }
        public int? U_SO1_FOLIOCOTIZA { get; set; }
        public int? U_SO1_FOLIODEVOL { get; set; }
        public int? U_SO1_NUMEROCLIENTE { get; set; }
        public int? U_SO1_FOLIODINERO { get; set; }
        public int? U_SO1_FOLIOTRASPAR1 { get; set; }
        public int? U_SO1_FOLIOTRASPASBO { get; set; }
        public int? U_SO1_FOLIOENTRADAPR { get; set; }
        public int? U_SO1_FOLIODOMICILIO { get; set; }
        public int? U_SO1_FOLIOPEDIDO { get; set; }
        public int? U_SO1_FOLIOCOBRANZAC { get; set; }
        public int? U_SO1_FOLIOANTICIPO { get; set; }
        public string? U_SO1_CODIGOCUENFACT { get; set; }
        public string? U_SO1_NOMBRECUENFACT { get; set; }
        public string? U_SO1_FORMATCUENFACT { get; set; }
        public string? U_SO1_CODIGOCUEDEVMD { get; set; }
        public string? U_SO1_NOMBRECUEDEVMD { get; set; }
        public string? U_SO1_FORMATCUEDEVMD { get; set; }
        public string? U_SO1_CODIGOCUEDEVDA { get; set; }
        public string? U_SO1_NOMBRECUEDEVDA { get; set; }
        public string? U_SO1_FORMATCUEDEVDA { get; set; }
        public short? U_SO1_LIMITEPARTIDAS { get; set; }
        public short? U_SO1_COPIASCONTADO { get; set; }
        public string? U_SO1_INDICFACTURA { get; set; }
        public string? U_SO1_INDICCREDITO { get; set; }
        public string? U_SO1_INDICREFACTURA { get; set; }
        public string? U_SO1_INDICFACDEVOL { get; set; }
        public string? U_SO1_INDICFACPEDIDO { get; set; }
        public string U_SO1_USARESCREMOTOS { get; set; } = null!;
        public string? U_SO1_ARTICULOANTICI { get; set; }
        public string U_SO1_FORZARANTICIPO { get; set; } = null!;
        public string U_SO1_FORZAVENBASPED { get; set; } = null!;
        public string U_SO1_BLOQUEARDESEXC { get; set; } = null!;
        public string U_SO1_USARGRUPOCLIEN { get; set; } = null!;
        public short? U_SO1_GRUPOCLIENTES { get; set; }
        public string U_SO1_VALIDARFCGRUPO { get; set; } = null!;
        public string U_SO1_USARDIRENTREGA { get; set; } = null!;
        public string U_SO1_VALIDIRENTPAR1 { get; set; } = null!;
        public string? U_SO1_NARTICULOANTI { get; set; }
        public string U_SO1_CONSFOLREIMFAC { get; set; } = null!;
        public string U_SO1_VALIDARINVCOTI { get; set; } = null!;
        public string U_SO1_VALIDARINVPEDI { get; set; } = null!;
        public string U_SO1_FACTURPEDIVERI { get; set; } = null!;
        public string U_SO1_CERRARPEDIFACT { get; set; } = null!;
        public string U_SO1_ACTIVARDESCESP { get; set; } = null!;
        public string U_SO1_PERMITIRDUPRFC { get; set; } = null!;
        public short? U_SO1_SERIEORDENCOMP { get; set; }
        public int? U_SO1_FOLIOORDENCOMP { get; set; }
        public short? U_SO1_SERIEFACTPROVE { get; set; }
        public int? U_SO1_FOLIOFACTPROVE { get; set; }
        public short? U_SO1_SERIEDEVOPROVE { get; set; }
        public short? U_SO1_SERIENOCRPROVE { get; set; }
        public int? U_SO1_FOLIODEVOCOMPR { get; set; }
        public string? U_SO1_CARTICULONOCAT { get; set; }
        public string? U_SO1_NARTICULONOCAT { get; set; }
        public string U_SO1_CERRARORCOMR1 { get; set; } = null!;
        public string U_SO1_CERRARORCOMSBO { get; set; } = null!;
        public string U_SO1_MANEJARCUVECLI { get; set; } = null!;
        public int? U_SO1_FOLIOCIERREZ { get; set; }
        public int? U_SO1_FOLIOENTRADAME { get; set; }
        public int? U_SO1_FOLIOSALIDAMER { get; set; }
        public short? U_SO1_SERIEENTRADAME { get; set; }
        public short? U_SO1_SERIESALIDAMER { get; set; }
        public string? U_SO1_CODIGOCUENGACA { get; set; }
        public string? U_SO1_NOMBRECUENGACA { get; set; }
        public string? U_SO1_FORMATCUENGACA { get; set; }
        public string? U_SO1_CODIGOCUENPECA { get; set; }
        public string? U_SO1_NOMBRECUENPECA { get; set; }
        public string? U_SO1_FORMATCUENPECA { get; set; }
        public string? U_SO1_CODDEUDORPRIN { get; set; }
        public string? U_SO1_NOMDEUDORPRIN { get; set; }
        public short? U_SO1_SERIEPOLIZA { get; set; }
        public int? U_SO1_FOLIODEPOSITOB { get; set; }
        public string? U_SO1_CODIGOCUENDIDE { get; set; }
        public string? U_SO1_NOMBRECUENDIDE { get; set; }
        public string? U_SO1_FORMATCUENDIDE { get; set; }
        public int? U_SO1_FOLIOCONTEOINV { get; set; }
        public short? U_SO1_INTHORASCOMP { get; set; }
        public int? U_SO1_FOLIOENTREGAFR { get; set; }
        public int? U_SO1_FOLIONOTACREDI { get; set; }
        public string? U_SO1_PREFINOTACREDI { get; set; }
        public short? U_SO1_SERIECREDINT { get; set; }
        public string U_SO1_FOLIOOBLIGADEV { get; set; } = null!;
        public decimal? U_SO1_FOLIONUMEROSER { get; set; }
        public string U_SO1_CONSFOLREIMNC { get; set; } = null!;
        public short? U_SO1_VIGENCIAPEDID { get; set; }
        public string U_SO1_CORTESCAJAPOR { get; set; } = null!;
        public string U_SO1_DEPOSITOBANDIA { get; set; } = null!;
        public string U_SO1_DEPOSBANCORTES { get; set; } = null!;
        public int? U_SO1_FOLIOOPORTUNIV { get; set; }
        public string U_SO1_SUCURSALMOVIL { get; set; } = null!;
        public string U_SO1_MODORDCOMPRA { get; set; } = null!;
        public string U_SO1_EXISTFACRES { get; set; } = null!;
        public string U_SO1_VALINVENTVTA { get; set; } = null!;
        public string U_SO1_VALINVCOLECT { get; set; } = null!;
        public string U_SO1_FORMINVCOLEC { get; set; } = null!;
        public string U_SO1_IMPPEDIDALMA { get; set; } = null!;
        public string? U_SO1_VALORIMPPEDA { get; set; }
        public string U_SO1_ENTRGRFRPAVE { get; set; } = null!;
        public string? U_SO1_VALORENTRGFR { get; set; }
        public string? U_SO1_LISTPRECIOMINI { get; set; }
        public string? U_SO1_NUMCLIENTEALT { get; set; }
        public string U_SO1_VENDEDORDEFACT { get; set; } = null!;
        public string U_SO1_CAMPALTVENDED { get; set; } = null!;
        public string U_SO1_SELEVENDEDEFE { get; set; } = null!;
        public string U_SO1_ACTVENDCLIENT { get; set; } = null!;
        public string? U_SO1_MAPCOBRADOR { get; set; }
        public string? U_SO1_VALCOBRADOR { get; set; }
        public int? U_SO1_FOLIOCANCELTRA { get; set; }
        public int? U_SO1_FOLIOCANTRASBO { get; set; }
        public string U_SO1_VALIDARALMCOL { get; set; } = null!;
        public string U_SO1_FORMVALFACTRES { get; set; } = null!;
        public short? U_SO1_VIGCANCELVENTA { get; set; }
        public string U_SO1_ESTADMENCLIMOS { get; set; } = null!;
        public int? U_SO1_FOLIOPERANULAD { get; set; }
        public string U_SO1_FORMVALPEDIDO { get; set; } = null!;
        public int? U_SO1_FOLIOPAGOCOMI { get; set; }
        public DateTime? U_SO1_FECHACONEX { get; set; }
        public short? U_SO1_HORACONEX { get; set; }
        public string? U_SO1_NOTIFCONEX { get; set; }
        public int? U_SO1_FOLIOMUEBLE { get; set; }
        public string? U_SO1_INDICNOTCREDIR { get; set; }
        public string? U_SO1_INDICNOTCREDEV { get; set; }
        public string? U_SO1_PREFINOTCREDIR { get; set; }
        public int? U_SO1_FOLIONOTCREDIR { get; set; }
        public short? U_SO1_SERIENOTCRDIR { get; set; }
        public int? U_SO1_FOLIONOTCRECON { get; set; }
        public string U_SO1_VISDESCLISTPRE { get; set; } = null!;
        public short? U_SO1_LISTAPRECBASE { get; set; }
        public int? U_SO1_FOLIOACTUAPRE { get; set; }
        public string? U_SO1_CLIENTEVENCON { get; set; }
        public string? U_SO1_NOMCLIEVENCON { get; set; }
        public string? U_SO1_ALMACENCONSIG { get; set; }
        public short? U_SO1_SERIEFACCONSIG { get; set; }
        public int? U_SO1_SERIECRCONSIG { get; set; }
        public string? U_SO1_INDICFACCONSIG { get; set; }
        public string? U_SO1_INDICCRCONSIG { get; set; }
        public string? U_SO1_PREFFACTURA6 { get; set; }
        public string? U_SO1_PREFNOTACREDI3 { get; set; }
        public int? U_SO1_FOLIOFACTURA6 { get; set; }
        public int? U_SO1_FOLIONOTACRED3 { get; set; }
        public int? U_SO1_FOLIOCRCONSIGN { get; set; }
        public string? U_SO1_LUGAREXPEDICI { get; set; }
        public string U_SO1_VISCOTIZACOPIA { get; set; } = null!;
        public short? U_SO1_CONPAGCOBROPAR { get; set; }
        public int? U_SO1_AFILIACIONBANC { get; set; }
        public int? U_SO1_FOLIOSUGEREN { get; set; }
        public string? U_SO1_CLIENTESUGERID { get; set; }
        public string? U_SO1_ARTICULOPROMDI { get; set; }
        public string? U_SO1_NARTICULOPROMD { get; set; }
        public int? U_SO1_FOLIODOCUDOCTO { get; set; }
        public int? U_SO1_FOLIOVALE { get; set; }
        public string? U_SO1_PROYECTO { get; set; }
        public string? U_SO1_NOMUSUARIOTAE { get; set; }
        public string? U_SO1_CONTRASENATAE { get; set; }
        public string? U_SO1_AFILTAE { get; set; }
        public short? U_SO1_SERIEFACTINT { get; set; }
        public short? U_SO1_SERIECREDINTCO { get; set; }
        public string? U_SO1_PREFPAGORECIBI { get; set; }
        public int? U_SO1_FOLIOPAGORECIB { get; set; }
        public string U_SO1_BLOQVENSINPREC { get; set; } = null!;
        public string? U_SO1_BANCOPROPIO { get; set; }
        public string U_SO1_DATOSFISMOSTRA { get; set; } = null!;
        public string U_SO1_SINCFOLIOSSA { get; set; } = null!;
        public int? U_SO1_FOLIOFINALF1 { get; set; }
        public int? U_SO1_FOLIOFINALF2 { get; set; }
        public int? U_SO1_FOLIOFINALF3 { get; set; }
        public int? U_SO1_FOLIOFINALF4 { get; set; }
        public int? U_SO1_FOLIOFINALF5 { get; set; }
        public int? U_SO1_FOLIOFINALF6 { get; set; }
        public int? U_SO1_FOLIOFINALNC1 { get; set; }
        public int? U_SO1_FOLIOFINALNC2 { get; set; }
        public int? U_SO1_FOLIOFINALNC3 { get; set; }
        public short? U_SO1_FOLIOSRESTALAR { get; set; }
        public int? U_SO1_FOLIOFINALPR { get; set; }
        public string? U_SO1_PREFTRASPASO { get; set; }
        public int? U_SO1_FOLIOSIGTRASPA { get; set; }
        public int? U_SO1_FOLIOFINTRASPA { get; set; }
        public string? U_SO1_PREFCOBCREDITO { get; set; }
        public int? U_SO1_FOLIOSIGCOBCRE { get; set; }
        public int? U_SO1_FOLIOINICOBCRE { get; set; }
        public string? U_SO1_PREFENTRDIRECT { get; set; }
        public int? U_SO1_FOLIOSIGENTDIR { get; set; }
        public int? U_SO1_FOLIOFINENTDIR { get; set; }
        public string? U_SO1_PREFDEVENTRDIR { get; set; }
        public int? U_SO1_FOLIOSIGDEENDI { get; set; }
        public int? U_SO1_FOLIOFINDEENDI { get; set; }
        public string? U_SO1_CNORMAREPARTO1 { get; set; }
        public string? U_SO1_CNORMAREPARTO2 { get; set; }
        public string? U_SO1_CNORMAREPARTO3 { get; set; }
        public string? U_SO1_CNORMAREPARTO4 { get; set; }
        public string? U_SO1_CNORMAREPARTO5 { get; set; }
        public string? U_SO1_NNORMAREPARTO1 { get; set; }
        public string? U_SO1_NNORMAREPARTO2 { get; set; }
        public string? U_SO1_NNORMAREPARTO3 { get; set; }
        public string? U_SO1_NNORMAREPARTO4 { get; set; }
        public string? U_SO1_NNORMAREPARTO5 { get; set; }
        public int? U_SO1_SERIEFACTUANTI { get; set; }
        public string? U_SO1_SERIEBOLETA { get; set; }
        public int? U_SO1_SERIEFACNOFISC { get; set; }
        public string U_SO1_ACTDESCPRONPAG { get; set; } = null!;
        public int? U_SO1_SUCURFAECHILE { get; set; }
        public string U_SO1_ACTENTFACRESBO { get; set; } = null!;
        public string U_SO1_ACTDETALLEVENT { get; set; } = null!;
        public int? U_SO1_SERIEENTREGADI { get; set; }
        public int? U_SO1_FOLIOENTREGADI { get; set; }
        public string? U_SO1_ESTACIONIMPDOS { get; set; }
        public string? U_SO1_TIPOSUCURSAL { get; set; }
        public string? U_SO1_PREFBOLETA1 { get; set; }
        public int? U_SO1_FOLIOBOLETA1 { get; set; }
        public int? U_SO1_FOLIOBOLETAF1 { get; set; }
        public string U_SO1_PROPONFOLIO { get; set; } = null!;
        public string U_SO1_VERIFNOTMOSTRA { get; set; } = null!;
        public int? U_SO1_NUMCLIENALTMOS { get; set; }
        public string U_SO1_CANCELADA { get; set; } = null!;
        public int? U_SO1_FOLTRABANORTE { get; set; }
        public string U_SO1_ORDCOMOTRASUC { get; set; } = null!;
        public string U_SO1_FORENTDIRBASAD { get; set; } = null!;
        public string? U_SO1_DIRECORREOELEC { get; set; }
        public string? U_SO1_CONTCORREOELEC { get; set; }
        public string? U_SO1_NOMMOSCORREOEL { get; set; }
        public string? U_SO1_DIRECAROPCOREL { get; set; }
        public string? U_SO1_ASUNTOCORREOFE { get; set; }
        public string? U_SO1_CUERPOCORREOFE { get; set; }
        public string? U_SO1_ASUNTOCORREONC { get; set; }
        public string? U_SO1_CUERPOCORREONC { get; set; }
        public string? U_SO1_ASUNTOCORREOPR { get; set; }
        public string? U_SO1_CUERPOCORREOPR { get; set; }
        public string? U_SO1_ASUNCORRDOCVEN { get; set; }
        public string? U_SO1_CUERCORRDOCVEN { get; set; }
        public string? U_SO1_DIRECORREONOFI { get; set; }
        public string? U_SO1_CONTCORREONOFI { get; set; }
        public string? U_SO1_NOMMOSCORRNOFI { get; set; }
        public string? U_SO1_DIAROPCORELNFI { get; set; }
        public string U_SO1_ACTCLACUCOSAEN { get; set; } = null!;
        public int? U_SO1_FOLIOSOLTRASPA { get; set; }
        public string? U_SO1_ASUNTOSOLTRASP { get; set; }
        public string? U_SO1_CUERPOSOLTRASP { get; set; }
        public string? U_SO1_ASUNTOSALTRASP { get; set; }
        public string? U_SO1_CUERPOSALTRASP { get; set; }
        public string? U_SO1_ASUNTONUECLIEN { get; set; }
        public string? U_SO1_CUERPONUECLIEN { get; set; }
        public int? U_SO1_FOLIOCOMANDA { get; set; }
        public string U_SO1_ACTCOMPNOTAMOS { get; set; } = null!;
        public string U_SO1_ACTTRASAUTO { get; set; } = null!;
        public string U_SO1_ACTALMASEPARA { get; set; } = null!;
        public string? U_SO1_ALMACENSEPARA { get; set; }
        public string? U_SO1_ALMARECETRASBO { get; set; }
        public int? U_SO1_FOLIOTRASAUTO { get; set; }
        public DateTime? U_SO1_ULTIFECHREPINV { get; set; }
        public int? U_SO1_ULTIHORAREPINV { get; set; }
        public string? U_SO1_ULTIHOCAREPINV { get; set; }
        public short? U_SO1_SERIETRASAUTO { get; set; }
        public string? U_SO1_VERSIONSINCRO { get; set; }
        public string? U_SO1_ALMACENEMIPROD { get; set; }
        public string? U_SO1_ALMACENRECPROD { get; set; }
        public string U_SO1_FORZARCIERREZ { get; set; } = null!;
        public int? U_SO1_FOLIORECPRODUC { get; set; }
        public int? U_SO1_SERIEORDENFABR { get; set; }
        public int? U_SO1_SERIEEMISIONPR { get; set; }
        public int? U_SO1_SERIERECIBOPRO { get; set; }
        public string? U_SO1_LEYENDAIMPRE { get; set; }
        public int? U_SO1_DIASRESDEFECTO { get; set; }
        public string U_SO1_INCARTISINSUGE { get; set; } = null!;
        public string U_SO1_INARTEXISINMOV { get; set; } = null!;
        public int? U_SO1_FOLIOTRASPDIRE { get; set; }
        public int? U_SO1_FOLIOCAJAS { get; set; }
        public int? U_SO1_FOLIODESP { get; set; }
        public int? U_SO1_SERIETRASPDIRE { get; set; }
        public string U_SO1_ACTALMASEPACOM { get; set; } = null!;
        public string? U_SO1_ALMACENSEPACOM { get; set; }
        public int? U_SO1_LISPREGANBRUTA { get; set; }
        public string? U_SO1_CODCLIMERMACOM { get; set; }
        public string? U_SO1_NOMCLIMERMACOM { get; set; }
        public int? U_SO1_SERIEENTMERCOM { get; set; }
        public int? U_SO1_FOLIOENTMERCOM { get; set; }
        public string U_SO1_FORDEPBANIGVEN { get; set; } = null!;
        public string U_SO1_VALCREVENCONTA { get; set; } = null!;
        public string U_SO1_SERALTENTFACRE { get; set; } = null!;
        public int? U_SO1_SERIEPOLCOFOPA { get; set; }
        public string? U_SO1_AFILIABANORTE { get; set; }
        public int? U_SO1_CODSUCTATELRPM { get; set; }
        public int? U_SO1_CODSUCTAMULRPM { get; set; }
        public int U_SO1_FOLIOTRANSARPM { get; set; }
        public int? U_SO1_SERIEFACANTICI { get; set; }
        public string? U_SO1_INDICFACANTICI { get; set; }
        public int U_SO1_FOLIOFACANTICI { get; set; }
        public int? U_SO1_FOLIOCIERREZP { get; set; }
        public string? U_SO1_CODSUCFOLEVA { get; set; }
        public int? U_SO1_SERIEBOLETARES { get; set; }
        public int? U_SO1_FOLIOPAGOPROVE { get; set; }
        public int? U_SO1_SERIEPAGOPROVE { get; set; }
        public int? U_SO1_SERIESOLTRASPA { get; set; }
        public int? U_SO1_FOLIOREFACT { get; set; }
        public string U_SO1_SINCFOLFACT1 { get; set; } = null!;
        public string U_SO1_SINCFOLFACT2 { get; set; } = null!;
        public string U_SO1_SINCFOLFACT3 { get; set; } = null!;
        public string U_SO1_SINCFOLFACT4 { get; set; } = null!;
        public string U_SO1_SINCFOLFACT5 { get; set; } = null!;
        public string U_SO1_SINCFOLFACT6 { get; set; } = null!;
        public string U_SO1_SINCFOLBOLE1 { get; set; } = null!;
        public string U_SO1_SINCFOLNOCR1 { get; set; } = null!;
        public string U_SO1_SINCFOLNOCR2 { get; set; } = null!;
        public string U_SO1_SINCFOLNOCR3 { get; set; } = null!;
        public string U_SO1_SINCFOLPARE1 { get; set; } = null!;
        public string U_SO1_SINCFOLTRAS1 { get; set; } = null!;
        public string U_SO1_SINCFOLCOCR1 { get; set; } = null!;
        public string U_SO1_SINCFOLENTDI { get; set; } = null!;
        public string U_SO1_SINCFOLDEENTDI { get; set; } = null!;
        public string U_SO1_SERALTFACANT { get; set; } = null!;
        public string U_SO1_ACTALMENTTRA { get; set; } = null!;
        public string? U_SO1_ALMENTTRAS { get; set; }
        public string? U_SO1_SUCURSALPADRE { get; set; }
        public string? U_SO1_ALMAVENTAFORA { get; set; }
        public string U_SO1_MOSTRARPROMAPL { get; set; } = null!;
        public string U_SO1_VIGENFACTMES { get; set; } = null!;
        public string U_SO1_VIGENDEVOMES { get; set; } = null!;
        public string? U_SO1_ALMATRASDIREXT { get; set; }
        public string U_SO1_ACTDEPUDB { get; set; } = null!;
        public int? U_SO1_NOMESDEPU { get; set; }
        public string? U_SO1_CODARTPROP { get; set; }
        public string U_SO1_FECHACIERREZ { get; set; } = null!;
        public string U_SO1_ACTHORDIARIO { get; set; } = null!;
        public string U_SO1_ACT24HDIARIO { get; set; } = null!;
        public string? U_SO1_HORINIDIARIO { get; set; }
        public string? U_SO1_MININIDIARIO { get; set; }
        public string? U_SO1_HORFINDIARIO { get; set; }
        public string? U_SO1_MINFINDIARIO { get; set; }
        public string U_SO1_ACTHORLUN { get; set; } = null!;
        public string U_SO1_ACT24HLUN { get; set; } = null!;
        public string? U_SO1_HORINILUN { get; set; }
        public string? U_SO1_MININILUN { get; set; }
        public string? U_SO1_HORFINLUN { get; set; }
        public string? U_SO1_MINFINLUN { get; set; }
        public string U_SO1_ACTHORMAR { get; set; } = null!;
        public string U_SO1_ACT24HMAR { get; set; } = null!;
        public string? U_SO1_HORINIMAR { get; set; }
        public string? U_SO1_MININIMAR { get; set; }
        public string? U_SO1_HORFINMAR { get; set; }
        public string? U_SO1_MINFINMAR { get; set; }
        public string U_SO1_ACTHORMIE { get; set; } = null!;
        public string U_SO1_ACT24HMIE { get; set; } = null!;
        public string? U_SO1_HORINIMIE { get; set; }
        public string? U_SO1_MININIMIE { get; set; }
        public string? U_SO1_HORFINMIE { get; set; }
        public string? U_SO1_MINFINMIE { get; set; }
        public string U_SO1_ACTHORJUE { get; set; } = null!;
        public string U_SO1_ACT24HJUE { get; set; } = null!;
        public string? U_SO1_HORINIJUE { get; set; }
        public string? U_SO1_MININIJUE { get; set; }
        public string? U_SO1_HORFINJUE { get; set; }
        public string? U_SO1_MINFINJUE { get; set; }
        public string U_SO1_ACTHORVIE { get; set; } = null!;
        public string U_SO1_ACT24HVIE { get; set; } = null!;
        public string? U_SO1_HORINIVIE { get; set; }
        public string? U_SO1_MININIVIE { get; set; }
        public string? U_SO1_HORFINVIE { get; set; }
        public string? U_SO1_MINFINVIE { get; set; }
        public string U_SO1_ACTHORSAB { get; set; } = null!;
        public string U_SO1_ACT24HSAB { get; set; } = null!;
        public string? U_SO1_HORINISAB { get; set; }
        public string? U_SO1_MININISAB { get; set; }
        public string? U_SO1_HORFINSAB { get; set; }
        public string? U_SO1_MINFINSAB { get; set; }
        public string U_SO1_ACTHORDOM { get; set; } = null!;
        public string U_SO1_ACT24HDOM { get; set; } = null!;
        public string? U_SO1_HORINIDOM { get; set; }
        public string? U_SO1_MININIDOM { get; set; }
        public string? U_SO1_HORFINDOM { get; set; }
        public string? U_SO1_MINFINDOM { get; set; }
        public string? U_SO1_ARTIDIVIXMONTO { get; set; }
        public short? U_SO1_CONFIGEXIST { get; set; }
        public string? U_SO1_FORMATCUENPACU { get; set; }
        public string? U_SO1_CODIGOCUENPACU { get; set; }
        public string? U_SO1_NOMBRECUENPACU { get; set; }
        public int? U_SO1_FILIAL { get; set; }
        public string U_SO1_ACTLOTESPEDIDO { get; set; } = null!;
        public string U_SO1_SERALTNOCR { get; set; } = null!;
        public int? U_SO1_FOLIOCANCECOBR { get; set; }
        public string? U_SO1_ESTADOTIEMPOS { get; set; }
        public string U_SO1_VENTACRUZINI { get; set; } = null!;
        public string U_SO1_VENTACRUZFIN { get; set; } = null!;
        public string U_SO1_LEVPEDIOTRASUC { get; set; } = null!;
        public int? U_SO1_GRUPOLADA { get; set; }
        public string? U_SO1_CATHORAS { get; set; }
        public string? U_SO1_CATHORASRESER { get; set; }
        public string U_SO1_ACTBUSCLICOIN { get; set; } = null!;
        public string U_SO1_ACTPRECECO { get; set; } = null!;
        public string U_SO1_VALSINCTIPOCAM { get; set; } = null!;
        public int? U_SO1_FOLIODOMIAVAN { get; set; }
        public int? U_SO1_FOLIOCOBRODOMI { get; set; }
        public string U_SO1_FORZASATRBASAD { get; set; } = null!;
        public string U_SO1_RECUPRELDEVCOM { get; set; } = null!;
        public string U_SO1_RESOLUCIONES { get; set; } = null!;
        public string? U_SO1_REGION { get; set; }
        public short? U_SO1_DIASVENCILOT { get; set; }
        public string? U_SO1_CODCAPOIMIT { get; set; }
        public string? U_SO1_NOMCAPOIMIT { get; set; }
        public string? U_SO1_FORCAPOIMIT { get; set; }
        public string? U_SO1_CODABPOIMIT { get; set; }
        public string? U_SO1_NOMABPOIMIT { get; set; }
        public string? U_SO1_FORABPOIMIT { get; set; }
        public string U_SO1_VISALCLIVETA { get; set; } = null!;
        public string U_SO1_SINCARSUCMOV { get; set; } = null!;
        public string U_SO1_SUCSERALTBOLE { get; set; } = null!;
        public string? U_SO1_FPAGAUTONOT { get; set; }
        public string? U_SO1_CATESTMESREST { get; set; }
        public int? U_SO1_FOLIOORDRECU { get; set; }
        public int? U_SO1_FOLIOCLIENESP { get; set; }
        public string? U_SO1_CATANTICIPO { get; set; }
        public int? U_SO1_FOLIOANTINOFAC { get; set; }
        public string? U_SO1_CATANTICPEDIDO { get; set; }
        public string? U_SO1_CATAFLUJMONITO { get; set; }
        public string? U_SO1_REPARDEFMONITO { get; set; }
        public int? U_SO1_FOLIOTRANSFDOM { get; set; }
        public string U_SO1_ACTIVAIMPRESEG { get; set; } = null!;
        public short? U_SO1_TIPOIMPRESEGME { get; set; }
        public int? U_SO1_FOLIOCANCELDOM { get; set; }
        public short? U_SO1_TIEMPADVLISESP { get; set; }
        public string? U_SO1_ARTCOBROPUNTOS { get; set; }
        public int? U_SO1_FOLIOAPLIANTI { get; set; }
        public int? U_SO1_INDICNOCREANTI { get; set; }
        public int? U_SO1_FOLIOREGCHECA { get; set; }
        public int? U_SO1_FOLIONOTCRECER { get; set; }
        public int? U_SO1_SERIENOTCRECER { get; set; }
        public short? U_SO1_INDICNOTCRECER { get; set; }
        public string U_SO1_ACTVALINVENT { get; set; } = null!;
        public string U_SO1_RECEPPEDINTER { get; set; } = null!;
        public short? U_SO1_FILTRADOCDESD { get; set; }
        public short? U_SO1_FILTRADOCHAST { get; set; }
        public string U_SO1_ACTFILDOCDESD { get; set; } = null!;
        public string U_SO1_ACTFILDOCHAST { get; set; } = null!;
        public string? U_SO1_MAPFILARTPROD { get; set; }
        public string? U_SO1_VALFILARTPROD { get; set; }
        public string U_SO1_FILTRARTPROVE { get; set; } = null!;
        public string U_SO1_GENEORVENFIPRO { get; set; } = null!;
        public string? U_SO1_CATAHORAENTDOM { get; set; }
        public string? U_SO1_CATAHORAENTPED { get; set; }
        public short? U_SO1_TIEMMINIENTDOM { get; set; }
        public short? U_SO1_TIEMMINIENTPED { get; set; }
        public string U_SO1_APLIDIASIGENDO { get; set; } = null!;
        public string U_SO1_APLIDIASIGENPE { get; set; } = null!;
        public string? U_SO1_CODIESTABGUATE { get; set; }
        public int U_SO1_FOLIOCANENTFAR { get; set; }
        public string U_SO1_ACTIMPTKENALMA { get; set; } = null!;
        public string U_SO1_MOSTRPANTRESVE { get; set; } = null!;
        public string U_SO1_OBLICANTMINPRO { get; set; } = null!;
        public string U_SO1_MOSTRAPARTIDEF { get; set; } = null!;
        public string U_SO1_OPERDEFRESURTI { get; set; } = null!;
        public string? U_SO1_ALMACENDEVOLUC { get; set; }
        public string U_SO1_AGPIMPRESIXALM { get; set; } = null!;
        public short? U_SO1_SERIEREQUICOMP { get; set; }
        public int? U_SO1_FOLIOREQUICOMP { get; set; }
        public string U_SO1_MANZONADOCVENT { get; set; } = null!;
        public string? U_SO1_MAPZONADOCVENT { get; set; }
        public string U_SO1_OBLZONADOCVENT { get; set; } = null!;
        public string? U_SO1_COLOR { get; set; }
        public short? U_SO1_TIPOMONITOREO { get; set; }
        public string? U_SO1_REPOBLIGATORIO { get; set; }
        public string? U_SO1_MVENTADOMICILI { get; set; }
        public string? U_SO1_ZONAOBLIGATORI { get; set; }
        public string? U_SO1_VENTARESGUARDO { get; set; }
        public string? U_SO1_ALMACRESGUARDO { get; set; }
        public string? U_SO1_MOSTRSUCREGION { get; set; }
        public string? U_SO1_SOLICOMPRAPEDI { get; set; }
        public string? U_SO1_ENTRPROVCOMPED { get; set; }
        public int? U_SO1_FOLIORUTA { get; set; }
        public string U_SO1_ASIGNAPARA4 { get; set; } = null!;
        public string? U_SO1_MAPASIPARA4 { get; set; }
        public string? U_SO1_COSRICCODISUCU { get; set; }
        public string U_SO1_OBLIKILOMDESPA { get; set; } = null!;
        public string U_SO1_OBLIOTROMOTIVO { get; set; } = null!;
        public short U_SO1_DEPTOSOLPEDCOM { get; set; }
        public string U_SO1_MOTIVORETENTRE { get; set; } = null!;
        public string U_SO1_AUTOCOTIZACION { get; set; } = null!;
        public string U_SO1_ACTIVIGENMOCZ { get; set; } = null!;
        public short? U_SO1_VIGENCIAMOCZ { get; set; }
        public string U_SO1_ACTIVIGENDOCZ { get; set; } = null!;
        public short? U_SO1_VIGENCIADOCZ { get; set; }
        public int? U_SO1_FOLTRADATACAP { get; set; }
    }
}
