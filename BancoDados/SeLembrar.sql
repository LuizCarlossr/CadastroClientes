use Corporativo

--INSERT DE CLIENTES
INSERT INTO clientes VALUES(123, '812163', 'Luiz Carlos', 'M', 'luiz@gmail.com', '1399999', '138888', 'SP')
INSERT INTO clientes VALUES(456, '777777', 'Carlos', 'M', 'Carlos@gmail.com', '777777', '77777', 'RJ')
INSERT INTO clientes VALUES(789, '888888', 'Solange', 'F', 'solange@gmail.com', '8888888', '8888', 'RJ')

--UPDATE DE CLIENTES
UPDATE clientes SET nome = 'Jose Carlos', email = 'josecarlos@gmail.com' WHERE IdCliente = 456

--SELECT DE CLIENTES
select * from clientes --WHERE IdCliente = 456

--DELETE DE CLIENTES
DELETE FROM CLIENTES WHERE IdCliente = 456