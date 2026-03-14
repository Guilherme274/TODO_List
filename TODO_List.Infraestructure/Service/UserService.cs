
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TODO_List.Application.DTOs.Security.Request;
using TODO_List.Application.DTOs.Security.Response;
using TODO_List.Application.Service;
using TODO_List.Domain.Entities;

namespace TODO_List.Infraestructure.Service
{
    public class UserService : IUsuarioService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signInManager;
        private ITokenService _tokenService;

        public UserService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, ITokenService token, ITokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task<string> RegistrarUsuario(RegisterRequest request)
        {
            Usuario entidadeUsuario = _mapper.Map<Usuario>(request);

            IdentityResult resultado = await _userManager.CreateAsync(entidadeUsuario, request.Senha);

            if (!resultado.Succeeded) throw new ApplicationException("Usuário não Cadastrado");
            else return "Usuário Criado";
        }
        
        public async Task<LoginResponse> LogarUsuario(LoginRequest request)
        {
            var usuarioEncontrado = await _userManager.FindByEmailAsync(request.Email);

            if (usuarioEncontrado is not null)
            {
                var resultado = await _signInManager.PasswordSignInAsync(request.Email, request.Senha, false, false);
                if (!resultado.Succeeded) throw new ApplicationException("Usuário não autenticado");

                var token = _tokenService.GerarToken(usuarioEncontrado);

                LoginResponse response = _mapper.Map<LoginResponse>(usuarioEncontrado);

                return new LoginResponse(response.Id, response.Nome, response.UserName, response.Email, response.DataNascimento, token);
            }
            else
                throw new ApplicationException("Usuário não encontrado");
        }
    }
}