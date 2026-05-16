namespace MusicStation_Pablo
{


    partial class MusicStationDataSet
    {
        partial class UsuariosRow
        {
            public override string ToString()
            {
                return $"{nome}  |  {email}  |  {senha}  |  {data_cadastro}";
            }
        }

        partial class ProfissionaisRow
        {
            public override string ToString()
            {
                // Usando as colunas reais da tabela Profissionais
                return $"{nome}  |  {email}  |  {telefone}";
            }
        }
    }
}
