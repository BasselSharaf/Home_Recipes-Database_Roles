﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace HomeRecipes_UserRoles_v1.HelperClasses
{
	/// <summary>Field Creation Class for entity CategoryEntity</summary>
	public partial class CategoryFields
	{
		/// <summary>Creates a new CategoryEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CategoryFieldIndex.Id); }}
		/// <summary>Creates a new CategoryEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CategoryFieldIndex.IsActive); }}
		/// <summary>Creates a new CategoryEntity.Name field instance</summary>
		public static EntityField2 Name { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CategoryFieldIndex.Name); }}
	}

	/// <summary>Field Creation Class for entity RecipeEntity</summary>
	public partial class RecipeFields
	{
		/// <summary>Creates a new RecipeEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeFieldIndex.Id); }}
		/// <summary>Creates a new RecipeEntity.Ingredients field instance</summary>
		public static EntityField2 Ingredients { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeFieldIndex.Ingredients); }}
		/// <summary>Creates a new RecipeEntity.Instructions field instance</summary>
		public static EntityField2 Instructions { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeFieldIndex.Instructions); }}
		/// <summary>Creates a new RecipeEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeFieldIndex.IsActive); }}
		/// <summary>Creates a new RecipeEntity.Title field instance</summary>
		public static EntityField2 Title { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeFieldIndex.Title); }}
	}

	/// <summary>Field Creation Class for entity RecipeCategoryEntity</summary>
	public partial class RecipeCategoryFields
	{
		/// <summary>Creates a new RecipeCategoryEntity.CategoryId field instance</summary>
		public static EntityField2 CategoryId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeCategoryFieldIndex.CategoryId); }}
		/// <summary>Creates a new RecipeCategoryEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeCategoryFieldIndex.Id); }}
		/// <summary>Creates a new RecipeCategoryEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeCategoryFieldIndex.IsActive); }}
		/// <summary>Creates a new RecipeCategoryEntity.RecipeId field instance</summary>
		public static EntityField2 RecipeId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RecipeCategoryFieldIndex.RecipeId); }}
	}

	/// <summary>Field Creation Class for entity RoleEntity</summary>
	public partial class RoleFields
	{
		/// <summary>Creates a new RoleEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RoleFieldIndex.Id); }}
		/// <summary>Creates a new RoleEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RoleFieldIndex.IsActive); }}
		/// <summary>Creates a new RoleEntity.RoleName field instance</summary>
		public static EntityField2 RoleName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(RoleFieldIndex.RoleName); }}
	}

	/// <summary>Field Creation Class for entity UserEntity</summary>
	public partial class UserFields
	{
		/// <summary>Creates a new UserEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Id); }}
		/// <summary>Creates a new UserEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.IsActive); }}
		/// <summary>Creates a new UserEntity.Password field instance</summary>
		public static EntityField2 Password { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Password); }}
		/// <summary>Creates a new UserEntity.RefreshToken field instance</summary>
		public static EntityField2 RefreshToken { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.RefreshToken); }}
		/// <summary>Creates a new UserEntity.Username field instance</summary>
		public static EntityField2 Username { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserFieldIndex.Username); }}
	}

	/// <summary>Field Creation Class for entity UserRoleEntity</summary>
	public partial class UserRoleFields
	{
		/// <summary>Creates a new UserRoleEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserRoleFieldIndex.Id); }}
		/// <summary>Creates a new UserRoleEntity.IsActive field instance</summary>
		public static EntityField2 IsActive { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserRoleFieldIndex.IsActive); }}
		/// <summary>Creates a new UserRoleEntity.RoleId field instance</summary>
		public static EntityField2 RoleId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserRoleFieldIndex.RoleId); }}
		/// <summary>Creates a new UserRoleEntity.UserId field instance</summary>
		public static EntityField2 UserId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(UserRoleFieldIndex.UserId); }}
	}
	

}