
/********************************************************************
created:    2018-04-07
author:     lixianmin

Copyright (C) - All Rights Reserved
*********************************************************************/

namespace ECS
{
    public interface IHaveEntity
    {
        Entity GetEntity();
        void SetEntity(Entity entity);
    }
}