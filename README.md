# 🧠 Currículo Digital - API (.NET 8)

Esta é a **API backend** desenvolvida em **ASP.NET Core 8.0** que serve como base de dados para o projeto **Currículo Digital** — uma aplicação web que apresenta meu currículo e portfólio de forma interativa.

> Este repositório trabalha em conjunto com o frontend disponível em:
> [👉 CurriculoDigitalFrontend](https://github.com/Denisdev2002/CurriculoDigitalFrontend)

---

## 📌 Funcionalidades da API

- ✅ Servir dados JSON como fonte para o frontend
- ✅ Endpoints públicos protegidos com **API Key**
- ✅ Suporte a `GET` de:
  - Informações pessoais
  - Experiências profissionais
  - Projetos
  - Redes sociais
- ✅ Leitura dos dados via arquivos `.json` (mock database)
- ✅ Middleware de autenticação customizado
- ✅ Pronto para deploy com **Docker**

---

## 🧱 Estrutura
    CurriculoDigital.Api/
    └── Data/
      ├── experience.json
      ├── personalInformation.json
      ├── socialMedia.json
      ├── projetct.json
    └── Filters/
    ├── Controllers/
    ├── Domain/
---

## 🚀 Tecnologias Utilizadas

- **ASP.NET Core 8.0**
- **C#**
- **System.Text.Json**
- **Docker**
- **Swagger** (para documentação)
- **IIS Kestrel** (default server)
- **API Key Middleware**

---

## 🐳 Docker

Para subir a API via Docker:

```bash
docker build -t curriculo-backend .
docker run -d -p 7128:7128 \
  -v "$PWD/CurriculoDigital.Infra/Data:/app/Data" \
  -e ASPNETCORE_URLS=http://+:7128 \
  --name curriculo-backend-container \
  curriculo-backend
