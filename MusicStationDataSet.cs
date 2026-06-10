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

        public partial class InstrumentosRow
        {
            public override string ToString()
            {
                return $"{nome} ({NomeEmpresa})  |  {descricao}  |  {preco_locacao:F2}  |  {disponivel}";
            }
        }

        partial class ServicosRow
        {
            public override string ToString()
            {
                return $"{nome}  |  {descricao} R$ {preco:F2} ";
            }
        }

        partial class PedidosRow
        {
            public override string ToString()
            {
                return $" Cliente: {NomeCliente}  |  {EmailCliente}  |  {total}   |  {data_pedido}  |  {acompanhamento}  ";
            }
        }

        partial class Servicos_PedidosRow
        {
            public override string ToString()
            {
                return $" Serviço: {NomeServico}  |  Profissional: {NomeProfissional}  |  Valor: R$ {valor_servico:F2}  |  Observação: {observacao}";
            }

        }

        partial class LocacoesRow
        {
            public override string ToString()
            {
                return $"  {NomeCliente}  |  {id_locacao}  |  {valor_total:F2}   |  {data_inicio}  |  {data_fim}  |  {status}";
            }
        }

        partial class Locacao_ItensRow
        {
            public override string ToString()
            {
                return $"Locação N°: {locacao_id}  |  Instrumento: {NomeInstrumento}  |  Dias: {dias}  |  Subtotal: R$ {subtotal:F2}";
            }
        }
    }
}

