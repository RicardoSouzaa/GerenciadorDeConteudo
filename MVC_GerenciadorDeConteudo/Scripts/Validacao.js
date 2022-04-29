var ValidaExclusao = function (id, evento)
{
    if (confirm("Confirmar Exclusão?"))
    {
            return true;
        }
        else
        {
            evento.preventDefault();
            return false;
    }
}
// adicionar o render na pasta view/shared/_layout.cshtml