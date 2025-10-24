# 🎂 Lead Page – Bolos da Ana

Uma landing page moderna e interativa desenvolvida com **Blazor App Unificado (.NET 9)** e **TailwindCSS v3**, criada para uma boleira divulgar seus produtos e receber pedidos personalizados.  
O projeto foi construído do zero com foco em design, responsividade e experiência de usuário.

---

## 🚀 Tecnologias Utilizadas

| Tecnologia | Função |
|-------------|--------|
| **.NET 9 (Blazor Unificado)** | Framework principal (front-end e back-end integrados) |
| **C#** | Linguagem base do projeto |
| **TailwindCSS v3** | Framework CSS utilitário para estilização moderna e responsiva |
| **PostCSS + Autoprefixer** | Ferramentas para compilar o Tailwind |
| **HTML/Razor Components** | Estrutura dos componentes visuais (Hero, Gallery, Testimonials etc.) |
| **npm / Node.js** | Gerenciamento do Tailwind e build de estilos |
| **Hot Reload (`dotnet watch`)** | Atualização em tempo real durante o desenvolvimento |

## 🎨 Recursos Implementados

✅ Layout responsivo com **TailwindCSS**  
✅ Estrutura modular com **componentes Razor**  
✅ **Galeria de produtos** com cards dinâmicos  
✅ **Depoimentos** de clientes renderizados por lista  
✅ **Formulário de pedidos** funcional (EditForm)  
✅ **Banner principal (Hero)** com imagem e chamada para ação  
✅ Separação de estilos (`input.css` e `site.css`)  
✅ Sistema de **rotas** via `<Router>` e `MainLayout`

---

## ⚙️ Como Rodar o Projeto

### 🧰 Pré-requisitos
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Node.js + npm](https://nodejs.org/en/download)

---

### 📦 Passo a Passo

 **Clonar o repositório**
```bash
git clone https://github.com/SEU_USUARIO/LeadPageBlazor.git
cd LeadPageBlazor
**Instalar as dependências do Tailwind**
npm install
npx tailwindcss -i ./wwwroot/css/input.css -o ./wwwroot/css/site.css --watch
