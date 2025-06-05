using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SubscriptionTracker.MVVM
{
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// The stored command
        /// </summary>
        private Action execute;

        /// <summary>
        /// The check whether the command can execute
        /// </summary>
        private Predicate<object> predicate;

        /// <summary>
        /// Event that will check the predicate when the value changes
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Relay command that can bind to a UI element and execute VeiwModel methods
        /// </summary>
        /// <param name="exe">The stored method to execute</param>
        /// <param name="pred">Optional condition to execute method</param>
        public RelayCommand(Action exe, Predicate<object> pred = null)
        {
            this.execute = exe;
            this.predicate = pred;
        }

        public bool CanExecute(object? parameter)
        {
            //If we didn't supply a predicate, it will always execute
            if (predicate == null)
                return true;

            return predicate(parameter);
        }

        public void Execute(object? parameter)
        {
            //Invoke the stored command
            execute.Invoke();
        }
    }
}
