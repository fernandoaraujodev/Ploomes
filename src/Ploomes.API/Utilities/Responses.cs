using System.Collections.Generic;
using Ploomes.API.ViewModes;

namespace Ploomes.API.Utilities
{
    /// <summary>
    /// Classe que padroniza erros de regra de negócio + erros internos
    /// </summary>
    public static class Responses
    {

        /// <summary>
        /// Mensagem de erro interno na aplicação
        /// </summary>
        /// <returns></returns>
        public static ResultViewModel ApplicationErrorMessage()
        {
            return new ResultViewModel
            {
                Message = "Ocorreu algum erro interno na aplicação, por favor tente novamente.",
                Success = false,
                Data = null
            };
        }

        /// <summary>
        /// Mensagem de erro de regra de negócio
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static ResultViewModel DomainErrorMessage(string message)
        {
            return new ResultViewModel
            {
                Message = message,
                Success = false,
                Data = null
            };
        }

        /// <summary>
        /// Mensagem de erro de regra de negócio + uma lista de erros
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errors"></param>
        /// <returns></returns>
        public static ResultViewModel DomainErrorMessage(string message, IReadOnlyCollection<string> errors)
        {
            return new ResultViewModel
            {
                Message = message,
                Success = false,
                Data = errors
            };
        }


        /// <summary>
        /// Mensagem de erro para Login e Senha incorretos
        /// </summary>
        /// <returns></returns>
        public static ResultViewModel UnauthorizedErrorMessage()
        {
            return new ResultViewModel
            {
                Message = "A combinação de login e senha está incorreta!",
                Success = false,
                Data = null
            };
        }

        /// <summary>
        /// Mensagem de erro interno na aplicação
        /// </summary>
        /// <returns></returns>
        public static ResultViewModel InternalServerErrorMessage()
        {
            return new ResultViewModel
            {
                Message = "Ocorreu um erro interno na aplicação, por favor tente novamente.",
                Success = false,
                Data = null
            };
        }
    }
}