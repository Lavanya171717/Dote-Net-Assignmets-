﻿CREATE TABLE USERDATA (
USERNAME VARCHAR(20) PRIMARY KEY,
PASSWORD VARCHAR(20)
)



INSERT INTO USERDATA VALUES ('ADMIN','123')
INSERT INTO USERDATA VALUES ('USER1','123')




SELECT * FROM USERDATA



select count(*) from userdata where username='admin' and password='123'