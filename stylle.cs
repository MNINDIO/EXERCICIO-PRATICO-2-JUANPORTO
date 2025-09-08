/* Resetando margens e padding */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

/* Estilo geral da página */
body {
    font-family: Arial, sans-serif;
    background-color: #f4f4f4;
    color: #333;
    line-height: 1.6;
    padding: 20px;
}

/* Cabeçalho */
header {
    text-align: center;
    margin-bottom: 30px;
}

h1 {
    font-size: 36px;
    color: #4CAF50;
}

p {
    font-size: 18px;
}

/* Estilos do formulário */
.form-container {
    margin: 0 auto;
    width: 80%;
    max-width: 600px;
    background-color: #fff;
    padding: 30px;
    border-radius: 8px;
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
}

form {
    display: flex;
    flex-direction: column;
}

label {
    font-size: 16px;
    margin-bottom: 8px;
}

input, textarea {
    padding: 12px;
    font-size: 16px;
    margin-bottom: 20px;
    border: 1px solid #ddd;
    border-radius: 4px;
}

input[type="text"], input[type="email"] {
    width: 100%;
}

textarea {
    width: 100%;
    resize: vertical;
}

button {
    padding: 12px 20px;
    background-color: #4CAF50;
    color: white;
    font-size: 16px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}

button:hover {
    background-color: #45a049;
}

/* Rodapé */
footer {
    text-align: center;
    margin-top: 40px;
    padding: 10px;
    background-color: #333;
    color: white;
}

footer p {
    font-size: 14px;
}
