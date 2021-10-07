using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.DAL;

namespace WinFormsApp1.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(string login, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
           tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals("")){
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public string cadastrar(string email, string senha, string confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);

            if (loginDao.tem)//se a mensagem que vir for true
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
