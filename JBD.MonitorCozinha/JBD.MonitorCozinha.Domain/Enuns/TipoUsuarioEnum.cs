using System.ComponentModel;

namespace JBD.MonitorCozinha.Domain.Enuns
{
    public enum TipoUsuarioEnum
    {
        [Description("ADMIN")]
        Admin = 1,  //Usuário administrador
        [Description("USER")]
        User = 2,   //Usuário que tem acesso aos Monitores
        [Description("GUEST")]
        Guest = 3,  //Usuário com acesso de demostração
        [Description("TEST")]
        Test = 4    //Usuário com acesso para testes
    }
}
