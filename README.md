# API de controle de alunos

## Como rodar?

1. De um `git clone` no repositório
2. Rode as migrations por meio do comando `Update-Database`
3. Starte o servidor e acesse o swagger para testar as rotas.

## Rotas da API
### Rotas de alunos (`/api/Student`)

| Método | Rota | Descrição |
| :--- | :--- | :--- |
| `POST` | `/api/Student` | Cria um aluno |
| `GET` | `/api/Student/FindAll` | Lista todos os alunos cadastrados |
| `GET` | `/api/Student/{id}` | Encontra um aluno específico pelo ID |
| `PUT` | `/api/Student` | Atualiza os dados de um aluno |
| `DELETE` | `/api/Student` | Exclui um aluno |

## Rotas de cursos (`/api/Course`)

| Método | Rota | Descrição |
| :--- | :--- | :--- |
| `POST` | `/api/Course` | Cria um curso |
| `GET` | `/api/Course/FindAll` | Lista todos os curso cadastrados |
| `GET` | `/api/Course/{id}` | Encontra curso específico pelo ID |
| `PUT` | `/api/Course` | Atualiza os dados de um curso |
| `DELETE` | `/api/Course` | Exclui um curso |

---

## Testes nas rotas `POST` e `GET`
### Presença
- O campo FirstName não pode ser nulo ou vazio.
<img width="1182" height="908" alt="matricula_aluno_dados_vazios" src="https://github.com/user-attachments/assets/32289d4b-f432-4aad-8efd-0ead1e201f81" />

### Extensão
- O campo FirstName deve ter no máximo 50 caracteres.
<img width="1202" height="912" alt="matricula_aluno_first_name_longo" src="https://github.com/user-attachments/assets/77877ec0-5cff-496d-8c01-f3365b6dfb3f" />

### Domínio
- O e-mail deve obrigatoriamente terminar com @faculdade.edu.
<img width="1182" height="907" alt="matricula_aluno_validacao_email" src="https://github.com/user-attachments/assets/7368c6cb-5bba-4845-8498-1f7332782e59" />

### Unicidade
- Antes de salvar, deve-se consultar o repositório para garantir que o e-mail informado já não pertença a outro aluno.
<img width="1187" height="912" alt="matricula_aluno_email_ja_existe" src="https://github.com/user-attachments/assets/c92066e9-f66e-4162-974f-99122e8115c6" />

### Fazer matrícula (post aluno)
<img width="1185" height="892" alt="matricula_aluno_post" src="https://github.com/user-attachments/assets/a5498d25-2457-402d-896f-b28f741d85d7" />

### Listar por ID
<img width="1190" height="760" alt="get_by_id_student" src="https://github.com/user-attachments/assets/31e86857-dba5-4a47-a879-28c5151f71d1" />

### Listar todos os alunos
<img width="1185" height="902" alt="get_all_students" src="https://github.com/user-attachments/assets/6a9408ed-bb92-4d54-a694-59d3629f4346" />

### Criar curso
<img width="1901" height="978" alt="criar_curso" src="https://github.com/user-attachments/assets/acb68739-4197-44aa-92ea-61496006e5cf" />

### Listar curso por ID
<img width="1182" height="897" alt="get_by_id_curso" src="https://github.com/user-attachments/assets/91000542-fe48-4db9-b784-70475bc9bf70" />

### Listar todos os cursos
<img width="1332" height="881" alt="get_all_cursos" src="https://github.com/user-attachments/assets/59792b63-11a4-446b-a2b0-a51902ba3eda" />

---

## Banco de Dados
### Tabelas
<img width="1072" height="817" alt="banco_de_dados_students" src="https://github.com/user-attachments/assets/f60305a9-98f9-40b8-9765-9fd9e28d2392" />
<img width="1023" height="663" alt="banco_de_dados_courses" src="https://github.com/user-attachments/assets/834768d1-7309-4d23-b034-56ce6f25daf3" />

---

## Swagger
<img width="1893" height="1007" alt="image" src="https://github.com/user-attachments/assets/3222fb8f-b2df-4769-bb01-a864f2cdb795" />

