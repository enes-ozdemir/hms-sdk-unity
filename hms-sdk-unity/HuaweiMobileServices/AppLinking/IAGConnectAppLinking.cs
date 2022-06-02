﻿using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.AppLinking
{
    public interface IAGConnectAppLinking
    {

        ITask<ResolvedLinkData> GetAppLinking();

        void SetCustomReferrer(IReferrerProvider provider);

    }
}
