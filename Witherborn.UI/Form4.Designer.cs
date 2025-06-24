using Witherborn.Controllers;
using Witherborn.Core.Services.Implementations;
using Witherborn.Core.Services.Interfaces;
using Witherborn.Data;

namespace Witherborn.UI
{
    partial class Form4
    {
        #region DbContext
        private static readonly WitherbornDbContext context = new WitherbornDbContext();
        #endregion

        #region Services
        private static readonly IItemService itemService = new ItemService(context);
        private static readonly IQueryService queryService = new QueryService(context);
        #endregion

        #region Controllers
        private static readonly ItemController itemController = new ItemController(itemService);
        private static readonly QueryController queryController = new QueryController(queryService);
        #endregion

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1902, 1033);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion
    }
}