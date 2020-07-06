using System;
using System.CodeDom.Compiler;

namespace Lab.Silosys
{
    public class Contenedor
    {
        private readonly int _alertCondition;

        private decimal _currentContent;

        public Contenedor(decimal capacity)
        {
            _currentContent = 0;
            _alertCondition = 90;
            Capacity = capacity;
        }

        //public Contenedor(decimal capacity, int alertCondition)
        //{
        //    _currentContent = 0;
        //    _alertCondition = alertCondition;
        //    Capacity = capacity;
        //}

        /// <summary>
        /// Evento para notificar cuando el contenedor está cercano a llenarse.
        /// </summary>
        public event EventHandler<EventArgs> WarningEventHandler;

        /// <summary>
        /// Capacidad del contenedor.
        /// </summary>
        public decimal Capacity { get; }

        /// <summary>
        /// Contenido actual del contenedor.
        /// </summary>
        public decimal CurrentContent => _currentContent;

        /// <summary>
        /// Capacidad usada del conetedor.
        /// </summary>
        public decimal AvailableCapacity => Capacity - CurrentContent;


        /// <summary>
        /// Realiza el llenado del contenedor.
        /// Cuando se agrega alguna cantidad, se debe modificar la caapacidad disponible
        /// </summary>
        /// <param name="quantity"></param>
        public void Fill(decimal quantity)
        {
            if (quantity < 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), $"{nameof(quantity)} debe tener un valor mayor o igual a cero.");

            var temp = _currentContent + quantity;
            if (temp > AvailableCapacity)
                throw new ArgumentOutOfRangeException(nameof(quantity), $"{nameof(quantity)} no debe exceder la capacidad disponible.");

            _currentContent = temp;

            var percentage = CalculateUsedPercentage();
            if (percentage >= _alertCondition)
            {
                OnFillEvent(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Realiza el vaciado del contenedor.
        /// </summary>
        public void Extact(decimal quantity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Realiza una llamada a un device x para obtener información del quantity.
        /// </summary>
        public void Process()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateUsedPercentage()
        {
            return CurrentContent * 100 / Capacity;
        }

        private void OnFillEvent(EventArgs eventArgs)
        {
            WarningEventHandler?.Invoke(this, eventArgs);
        }
    }
}
