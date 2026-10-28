# API JWT com ASP.NET Core

## Descrição

Este projeto consiste em uma API REST desenvolvida em C# utilizando ASP.NET Core Web API, com implementação de autenticação baseada em JWT (JSON Web Token).

O objetivo do projeto é demonstrar o funcionamento da autenticação e autorização em APIs, utilizando credenciais fixas definidas no código para fins didáticos, sem utilização de banco de dados.

---

## Tecnologias Utilizadas

- C#
- ASP.NET Core Web API
- JWT Authentication
- Visual Studio
- Postman

---

## Credenciais de Teste

Utilize as credenciais abaixo para realizar o login:

```json
{
  "usuario": "admin",
  "senha": "123456"
}
```

---

## Como Executar o Projeto

### 1. Clonar o Repositório

```bash
git clone <URL_DO_REPOSITORIO>
```

### 2. Acessar a Pasta do Projeto

```bash
cd JwtApiAula
```

### 3. Restaurar os Pacotes

```bash
dotnet restore
```

### 4. Executar a Aplicação

```bash
dotnet run
```

A API será iniciada e estará disponível na URL informada pelo terminal.

---

## Endpoints

### Login

**POST**

```http
/api/auth/login
```

#### Corpo da Requisição

```json
{
  "usuario": "admin",
  "senha": "123456"
}
```

#### Resposta de Sucesso

```json
{
  "token": "JWT_TOKEN"
}
```

---

### Perfil do Usuário (Protegido)

**GET**

```http
/api/usuario/perfil
```

#### Autenticação

Enviar o token JWT obtido no login através do cabeçalho:

```http
Authorization: Bearer TOKEN
```

#### Resposta

```json
{
  "mensagem": "Olá admin, acesso autorizado!"
}
```

---

## Testes Realizados no Postman

### Teste 1 – Login Válido

Requisição:

```json
{
  "usuario": "admin",
  "senha": "123456"
}
```

Resultado esperado:

```http
200 OK
```

Retorno de um token JWT válido.

---

### Teste 2 – Login Inválido

Requisição:

```json
{
  "usuario": "admin",
  "senha": "senhaErrada"
}
```

Resultado esperado:

```http
401 Unauthorized
```

---

### Teste 3 – Acesso sem Token

Acessar:

```http
GET /api/usuario/perfil
```

sem enviar token.

Resultado esperado:

```http
401 Unauthorized
```

---

### Teste 4 – Acesso com Token Válido

Acessar:

```http
GET /api/usuario/perfil
```

enviando o token JWT.

Resultado esperado:

```http
200 OK
```

---

## Estrutura do Projeto

```text
JwtApiAula
│
├── Controllers
│   ├── AuthController.cs
│   └── UsuarioController.cs
│
├── Models
│   └── LoginRequest.cs
│
├── Services
│   └── TokenService.cs
│
├── Program.cs
├── appsettings.json
└── README.md
```

---

## Evidências dos Testes

As capturas de tela dos testes realizados no Postman encontram-se na pasta:

```text
/evidencias
```

ou anexadas conforme solicitado na atividade.

---

## Autor

Projeto desenvolvido para fins acadêmicos na disciplina de Desenvolvimento Web/API.