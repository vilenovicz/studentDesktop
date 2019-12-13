--select Id, Code, Name  from Competences
exec uspNewCompetence 2,2

exec uspNewPerson "Семенов","Семен", "02.12.2019 14:55", 1

--select * from person_competence order by 2

--delete from person_competence where id in (13)

select * from Persons