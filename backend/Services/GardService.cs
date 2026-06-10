using system;

public bool ValideraStatus(string statusen) // bool datatyp som bara kan sant eller falskt
{
    if (statusen == "Röd" || statusen == "Orange" || statusen == "Grön")
    {
      return true;  
    }

    return false;
}

public bool ValideraNamn(string namnet)
{
    if(string.IsNUllOrEmpty (namnet))
    {} // Ska göra if satser
}