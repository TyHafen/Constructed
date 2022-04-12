CREATE TABLE IF NOT EXISTS accounts(
  id int NOT NULL AUTO_INCREMENT primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS contractors(
  id int NOT NULL AUTO_INCREMENT primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name TEXT NOT NULL
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS companies(
  id int NOT NULL AUTO_INCREMENT primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name TEXT NOT NULL,
  location TEXT NOT NULL
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS jobs(
  id int NOT NULL AUTO_INCREMENT primary key COMMENT "primary key",
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  companyId INT NOT NULL,
  contractorId INT NOT NULL,
  FOREIGN KEY (companyId) REFERENCES companies(id) ON DELETE CASCADE,
  FOREIGN KEY (contractorId) REFERENCES contractors(id) ON DELETE CASCADE
) default charset utf8 COMMENT '';
SELECT
  *
FROM
  jobs;
INSERT INTO
  jobs (companyId, contractorId)
VALUES
  (1, 2);
SELECT
  c.*,
  comp.*,
  j.id AS jobId,
  c.id AS contractorId,
  comp.id AS companyId
FROM
  jobs j
  JOIN contractors c ON c.id = j.contractorId
  JOIN companies comp ON comp.Id = j.companyId
WHERE
  j.companyId = 1;