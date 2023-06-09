﻿using PortalTransparenciaDeps.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IHistoricoQueryService
    {
        List<HistoricoDto> ListHistorico();
        List<HistoricoDto> ListHistoricoByUser(int idUser);
        HistoricoDto GetHistorico(int id);
    }
}
