using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
using SignalR.EntityLayer.Entities;
#pragma warning restore CS0105 // Using directive appeared previously in this namespace

namespace SignalR.DataAccessLayer.Abstract
{
	public interface IFeatureDal: IGenericDal<Feature>
	{
	}
}
