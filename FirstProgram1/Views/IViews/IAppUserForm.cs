namespace FirstProgram1.Views.IViews
{
    public interface IAppUserForm
    {
        string Id { get; set; }
        bool IsSuccessful { set; }
        string Message { set; }
        string AppUserName { get; set; }
        int ProgramId { get; set; }
        string UserName { get; set; }

        event EventHandler AddNew;

        void getAllPrograms(BindingSource bindingSource);
        void getAllAppUsers(BindingSource bindingSource);
    }
}