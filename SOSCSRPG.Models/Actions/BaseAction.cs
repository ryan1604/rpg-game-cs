﻿namespace SOSCSRPG.Models.Actions
{
    public abstract class BaseAction
    {
        protected readonly GameItem _itemInUse;

        public event EventHandler<string> OnActionPerformed;

        protected BaseAction(GameItem itemInUse)
        {
            _itemInUse = itemInUse;
        }

        protected void ReportResults(string result)
        {
            OnActionPerformed?.Invoke(this, result);
        }
    }
}
