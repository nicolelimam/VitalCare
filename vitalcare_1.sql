-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Jun-2023 às 02:13
-- Versão do servidor: 10.4.27-MariaDB
-- versão do PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `vitalcare`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cad_idoso`
--

CREATE TABLE `cad_idoso` (
  `id_idoso` int(11) NOT NULL,
  `nome_idoso` varchar(80) NOT NULL,
  `data_nascimento_idoso` varchar(15) NOT NULL,
  `rg_idoso` varchar(15) NOT NULL,
  `cpf_idoso` varchar(15) NOT NULL,
  `nome_responsavel` varchar(80) NOT NULL,
  `telefone_responsavel` varchar(15) NOT NULL,
  `n_quarto` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `cad_idoso`
--

INSERT INTO `cad_idoso` (`id_idoso`, `nome_idoso`, `data_nascimento_idoso`, `rg_idoso`, `cpf_idoso`, `nome_responsavel`, `telefone_responsavel`, `n_quarto`) VALUES
(4, 'zeze', '12/02/2000', '162542327', '26537264726', 'YRYRY', '12863512746', '43'),
(5, 'carol', '12/12/1920', '124398713249', '43543452345', 'jonatas', '12312342323', '65');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cad_usuario`
--

CREATE TABLE `cad_usuario` (
  `id_usuario` int(11) NOT NULL,
  `nome` varchar(90) NOT NULL,
  `nome_usuario` varchar(80) NOT NULL,
  `cargo_usuario` varchar(60) NOT NULL,
  `usuario_email` varchar(100) NOT NULL,
  `senha_login` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `cad_usuario`
--

INSERT INTO `cad_usuario` (`id_usuario`, `nome`, `nome_usuario`, `cargo_usuario`, `usuario_email`, `senha_login`) VALUES
(20, 'miguel', 'miguel', 'Cuidador', 'miguel@gmail', '1234'),
(21, 'jao', 'jao', 'Administrador', 'jao@fatec', '1234'),
(22, 'ana', 'ana', 'Administrador', 'ana@gmail', '1234');

-- --------------------------------------------------------

--
-- Estrutura da tabela `calendario`
--

CREATE TABLE `calendario` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_idoso` int(11) NOT NULL,
  `data` varchar(15) NOT NULL,
  `titulo` varchar(80) NOT NULL,
  `evento` varchar(800) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `comorbidade`
--

CREATE TABLE `comorbidade` (
  `id_comorbidade` int(11) NOT NULL,
  `nome_comorbidade` varchar(80) NOT NULL,
  `descricao_comorbidade` varchar(800) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `comorbidade`
--

INSERT INTO `comorbidade` (`id_comorbidade`, `nome_comorbidade`, `descricao_comorbidade`) VALUES
(3, 'Arritmias cardíacas\r\n', ''),
(4, 'Cardiopatia hipertensiva\r\n', ''),
(5, 'Cirrose hepática\r\n', ''),
(6, 'Diabetes mellitus\r\n', ''),
(7, 'Doença renal crônica\r\n', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `ficha_medica`
--

CREATE TABLE `ficha_medica` (
  `id_ficha_medica` int(11) NOT NULL,
  `nome_idoso` varchar(100) NOT NULL,
  `idade_idoso` int(100) NOT NULL,
  `quarto` varchar(30) NOT NULL,
  `nome_comorbidade` varchar(100) NOT NULL,
  `tratamento_ficha_medica` varchar(800) NOT NULL,
  `observacoes` varchar(600) NOT NULL,
  `nome_medico` varchar(80) NOT NULL,
  `nome_cuidador` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `ficha_medica`
--

INSERT INTO `ficha_medica` (`id_ficha_medica`, `nome_idoso`, `idade_idoso`, `quarto`, `nome_comorbidade`, `tratamento_ficha_medica`, `observacoes`, `nome_medico`, `nome_cuidador`) VALUES
(10, 'zeze', 89, '72', 'Cardiopatia hipertensiva\r\n', 'Dipirona', 'Ta cansado', 'FAFA', 'miguel');

-- --------------------------------------------------------

--
-- Estrutura da tabela `medicamento`
--

CREATE TABLE `medicamento` (
  `id_medicamento` int(11) NOT NULL,
  `nome_medicamento` varchar(80) NOT NULL,
  `indicacao_medicamento` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `medicamento`
--

INSERT INTO `medicamento` (`id_medicamento`, `nome_medicamento`, `indicacao_medicamento`) VALUES
(1, 'Dipirona', 'Dores de cabeça'),
(2, 'Dorflex', 'Dores musculares'),
(3, 'Insulina', 'Diabetes');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cad_idoso`
--
ALTER TABLE `cad_idoso`
  ADD PRIMARY KEY (`id_idoso`);

--
-- Índices para tabela `cad_usuario`
--
ALTER TABLE `cad_usuario`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Índices para tabela `calendario`
--
ALTER TABLE `calendario`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_idoso` (`id_idoso`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Índices para tabela `comorbidade`
--
ALTER TABLE `comorbidade`
  ADD PRIMARY KEY (`id_comorbidade`);

--
-- Índices para tabela `ficha_medica`
--
ALTER TABLE `ficha_medica`
  ADD PRIMARY KEY (`id_ficha_medica`);

--
-- Índices para tabela `medicamento`
--
ALTER TABLE `medicamento`
  ADD PRIMARY KEY (`id_medicamento`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cad_idoso`
--
ALTER TABLE `cad_idoso`
  MODIFY `id_idoso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `cad_usuario`
--
ALTER TABLE `cad_usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT de tabela `calendario`
--
ALTER TABLE `calendario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `comorbidade`
--
ALTER TABLE `comorbidade`
  MODIFY `id_comorbidade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `ficha_medica`
--
ALTER TABLE `ficha_medica`
  MODIFY `id_ficha_medica` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `medicamento`
--
ALTER TABLE `medicamento`
  MODIFY `id_medicamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `calendario`
--
ALTER TABLE `calendario`
  ADD CONSTRAINT `calendario_ibfk_1` FOREIGN KEY (`id_idoso`) REFERENCES `cad_idoso` (`id_idoso`),
  ADD CONSTRAINT `calendario_ibfk_2` FOREIGN KEY (`id_usuario`) REFERENCES `cad_usuario` (`id_usuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
