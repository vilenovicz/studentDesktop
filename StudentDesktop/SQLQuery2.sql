--select Id, Code, Name  from Competences
exec uspNewCompetence 2,2


select * from person_competence order by 2

delete from person_competence where id in (13)