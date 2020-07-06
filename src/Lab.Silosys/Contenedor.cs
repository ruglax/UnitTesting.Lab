using System;

namespace Lab.Silosys
{
    public class Contenedor
    {
        private decimal _currentContent;

        public Contenedor()
        {
            _currentContent = 0;
        }

        public delegate void FillEventHandler(object sender, EventArgs e);

        public event FillEventHandler FillEvent;

        /// <summary>
        /// Capacidad del contenedor.
        /// </summary>
        public decimal Capacity { get; } = 1000;

        public decimal Used => _currentContent * 100 / Capacity;

        /// <summary>
        /// Realiza el llenado del contenedor.
        /// </summary>
        /// <param name="contenido"></param>
        public void Fill(decimal contenido)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Realiza el vaciado del contenedor.
        /// </summary>
        public void Clear()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Realiza el vaciado del contenedor.
        /// <param name="quantity">Cantidad de materia a vaciar del contenedor.</param>
        /// </summary>
        public void Clear(decimal quantity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Realiza una llamada a un device x para obtener información del contenido.
        /// </summary>
        public void Process()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnFillEvent()
        {
            throw new NotImplementedException();
            //FillEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
