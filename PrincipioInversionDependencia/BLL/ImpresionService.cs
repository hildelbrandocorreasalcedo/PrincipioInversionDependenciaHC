using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImpresionService
    {

        DocumentoService documento = new DocumentoService();
        IFormato formato;

        public ImpresionService(IFormato formatoDocumento)
        {
            formato = formatoDocumento;
        }

        public string Imprimir()
        {
            return " Yo imprimo " + formato.Generar() + documento.crearDocumeto();
        }
    }
}
