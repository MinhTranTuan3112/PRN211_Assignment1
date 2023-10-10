using DataAccess.Repository;
using MyStoreWinApp.Presenter;
using MyStoreWinApp.View;

namespace MyStoreWinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IfrmLogin loginForm = new frmLogin();
            IMemberRepository repository = new MemberRepository();
            new LoginPresenter(loginForm, repository);
            Application.Run(loginForm as Form);
        }
    }
}