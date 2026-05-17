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

                return $"{NomeProfissional}  |  {NomeCargo}";
            }
        }

        public partial class ClientesRow
        {
            public override string ToString()
            {
                return $"{NomeCliente}  |  {EmailCliente}  |  {telefone}  |  {rua}  |  {numero}  ";
            }
        }

        public partial class AdministradoresRow
        {
            public override string ToString()
            {
                return $"{NomeAdmin}  |  {EmailAdmin}  |  {nivel_acesso}  |  {observacoes}";
            }
        }

        public partial class EmpresasRow
        {
            public override string ToString()
            {
                return $"{nome_fantasia}  |  {razao_social}  |  {cnpj}  |  {email}  |  {telefone}  |  {descricao}";
            }
        }

        partial class InstrumentosRow
        {
            public override string ToString()
            {
                return $"{nome} ({NomeEmpresa})  |  {descricao}  |  {preco_locacao:F2}  |  {disponivel}";
            }
        }
    }
}
