-- -----------------------------------------------------
-- Schema how7
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `how7` DEFAULT CHARACTER SET utf8 ;
USE `how7` ;

-- -----------------------------------------------------
-- Table `how7`.`TipoImoveis`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `how7`.`TipoImoveis` (
  `id` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
;

-- -----------------------------------------------------
-- Table `how7`.`Imoveis`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `how7`.`Imoveis` (
  `id` INT NOT NULL,
  `tipo` INT NOT NULL,
  `descricao` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`, `tipo`),
  CONSTRAINT `fk_Imoveis_TipoImoveis`
    FOREIGN KEY (`tipo`)
    REFERENCES `how7`.`TipoImoveis` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

-- -----------------------------------------------------
-- Table `how7`.`Pagamentos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `how7`.`Pagamentos` (
  `id` INT NOT NULL,
  `imovel` INT NOT NULL,
  `data` DATETIME NOT NULL,
  `valor` DECIMAL NOT NULL,
  PRIMARY KEY (`id`, `imovel`),
  CONSTRAINT `fk_Pagamentos_Imoveis1`
    FOREIGN KEY (`imovel`)
    REFERENCES `how7`.`Imoveis` (`tipo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;


