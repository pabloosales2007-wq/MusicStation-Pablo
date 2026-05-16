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
                return $"{nome}  |  {email}  |  {telefone}";
            }
        }

        partial class CargosRow
        {
            public override string ToString()
            {
                return $"{nome}  |  {descricao}";
            }
        }

        partial class Profissional_CargoRow
        {
            public override string ToString()
            {
                // Se você fez o INNER JOIN, use os nomes das colunas da própria linha diretamente!
                return $"{NomeProfissional}  |  {NomeCargo}";
            }
        }
    }
}
