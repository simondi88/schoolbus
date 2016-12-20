/*
 * REST API Documentation for Schoolbus
 *
 * API Sample
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using System;
using Xunit;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Npgsql;
using Microsoft.EntityFrameworkCore;
using Moq;
using SchoolBusAPI;
using SchoolBusAPI.Models;
using SchoolBusAPI.Controllers;
using SchoolBusAPI.Services.Impl;

namespace SchoolBusAPI.Test
{
	public class UserApiUnitTest 
    { 
		
		private readonly UserApiController _UserApi;
		
		/// <summary>
        /// Setup the test
        /// </summary>        
		public UserApiUnitTest()
		{			
                    Mock<DbAppContext> dbAppContext = new Mock<DbAppContext>();
			
                    /*
			
                    Here you will need to mock up the context.
			
            ItemType fakeItem = new ItemType(...);

            Mock<DbSet<ItemType>> mockList = MockDbSet.Create(fakeItem);

            dbAppContext.Setup(x => x.ModelEndpoint).Returns(mockItem.Object);

                    */

                    UserApiService _service = new UserApiService(dbAppContext.Object);
			
                    this._UserApi = new UserApiController (_service);

		}
	
		
		[Fact]
		/// <summary>
        /// Unit test for UsersIdFavouritesGet
        /// </summary>
		public void TestUsersIdFavouritesGet()
		{
			// Add test code here
			// it may look like: 
			//  var result = _UserApiController.UsersIdFavouritesGet();
			//  Assert.True (result == expected-result);

            Assert.True(true);
		}		
        
		
		[Fact]
		/// <summary>
        /// Unit test for UsersIdGet
        /// </summary>
		public void TestUsersIdGet()
		{
			// Add test code here
			// it may look like: 
			//  var result = _UserApiController.UsersIdGet();
			//  Assert.True (result == expected-result);

            Assert.True(true);
		}		
        
		
		[Fact]
		/// <summary>
        /// Unit test for UsersIdNotificationGet
        /// </summary>
		public void TestUsersIdNotificationGet()
		{
			// Add test code here
			// it may look like: 
			//  var result = _UserApiController.UsersIdNotificationGet();
			//  Assert.True (result == expected-result);

            Assert.True(true);
		}		
        
    }
}
