SELECT * FROM emplouee t1
WHERE t1.salary > (SELECT salary FROM emplouee t2 WHERE t2.id = t1.chief_id)