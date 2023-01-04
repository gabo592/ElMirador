﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ElMirador.Presentacion.Base
{
    public abstract partial class FrmBuscador : Form
    {
        public FrmBuscador(string titulo)
        {
            InitializeComponent();
            LblTitulo.Text = titulo;
        }

        #region Protected Methods

        /// <summary>
        /// Evento encargado para filtrar las búsquedas de los registros contenidos
        /// por el DataGridView.
        /// </summary>
        /// <param name="text">Texto a filtrar.</param>
        protected abstract void OnTxtBuscar_TextChanged(string text);

        /// <summary>
        /// Evento encargado de proveer la lógica para proveer las herramientas
        /// para agregar un nuevo registro a la base de datos.
        /// </summary>
        /// <param name="sender">Objeto que manda a llamar al evento.</param>
        /// <param name="args">Argumentos del evento.</param>
        protected abstract void OnBtnCrear_Click(object sender, EventArgs args);

        /// <summary>
        /// Evento encargado de proveer la lógica para proveer las herramientas
        /// para modificar o actualizar un registro a la base de datos.
        /// </summary>
        /// <param name="sender">Objeto que manda a llamar al evento.</param>
        /// <param name="args">Argumentos del evento.</param>
        protected abstract void OnBtnModificar_Click(object sender, EventArgs args);

        /// <summary>
        /// Evento encargado de proveer la lógica para proveer las herramientas
        /// para eliminar un registro de la base de datos.
        /// </summary>
        /// <param name="sender">Objeto que manda a llamar al evento.</param>
        /// <param name="args">Argumentos del evento.</param>
        protected abstract void OnBtnEliminar_Click(object sender, EventArgs args);

        /// <summary>
        /// Carga la información al DataGridView de una colección de registros del
        /// tipo especificado.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo.</typeparam>
        /// <param name="models">Colección de modelos a cargar.</param>
        protected void LoadDataGrid<TModel>(IEnumerable<TModel> models) where TModel : new()
        {
            if (models is null) return;

            DgvCatalogo.DataSource = models.ToArray();
        }

        /// <summary>
        /// Busca en la lista de modelos seleccionados y devuelve la primer coincidencia.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo que contiene el DataGridView.</typeparam>
        /// <returns>Primer modelo seleccionado.</returns>
        protected TModel GetSelected<TModel>() where TModel : new()
        {
            if (DgvCatalogo.SelectedRows.Count == 0) return default;

            TModel[] models = (TModel[])DgvCatalogo.DataSource;

            return models[DgvCatalogo.SelectedRows[0].Index];
        }


        #endregion

        private void TxtBuscar_TextChange(object sender, EventArgs e)
        {
            OnTxtBuscar_TextChanged(TxtBuscar.Text);
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            OnBtnCrear_Click(sender, e);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            OnBtnModificar_Click(sender, e);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            OnBtnEliminar_Click(sender, e);
        }
    }
}
