using System;


namespace XulambsFoods {    
    public class Pizza {

        /// <summary>
        /// Lembre-se:
        // ENTENDER O PROBLEMA!!!
        //Regra 0 -- não entre em pânico
        //Regra 1 -- não viaje
        /// </summary>
        /// 
        #region atributos
        int _maxIngredientes;
        double _precoBase;
        int _quantIngredientes;
        double _valorPorAdicional;
        string _descricao;
        #endregion

        #region construtores

        private void Init(int adicionais)
        {
            _descricao = "\nPizza";
            _maxIngredientes = 8;
            _precoBase = 29d;
            AdicionarIngredientes(adicionais);
            _valorPorAdicional = 5d;
            
        }

        public Pizza() {
            Init(0);
        }

        public Pizza(int adicionais) {

            Init(adicionais);
        }
        #endregion

        #region métodos privados
        private double ValorAdicionais() {

            return _quantIngredientes * _valorPorAdicional;
                
        }

        private void ModificarDescricao() {
            _descricao = $"\nPizza com {_quantIngredientes} adicionais";
        }

        private bool PodeAdicionar(int quantos) {

            return (quantos > 0 && _quantIngredientes + quantos <= _maxIngredientes);


        }
        #endregion

        #region métodos públicos
        public double CalcularValorFinal() {
            return _precoBase + ValorAdicionais();
        }

        public int AdicionarIngredientes(int quantos) {
            if (PodeAdicionar(quantos)) {
                _quantIngredientes = _quantIngredientes + quantos;
                ModificarDescricao();
            }
            return _quantIngredientes;
        }

        public string GerarCupom() {
            string cupom = "Cupom de venda";
            cupom += "\n--------------------";
            cupom += _descricao;
            cupom += $"\nValor final: {CalcularValorFinal():C2}";
            cupom += "\n--------------------";
            return cupom;


        }
        #endregion

    }
}