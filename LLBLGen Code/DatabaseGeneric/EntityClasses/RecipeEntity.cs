﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using HomeRecipes_UserRoles_v1.HelperClasses;
using HomeRecipes_UserRoles_v1.FactoryClasses;
using HomeRecipes_UserRoles_v1.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace HomeRecipes_UserRoles_v1.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Recipe'.<br/><br/></summary>
	[Serializable]
	public partial class RecipeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<RecipeCategoryEntity> _recipeCategories;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static RecipeEntityStaticMetaData _staticMetaData = new RecipeEntityStaticMetaData();
		private static RecipeRelations _relationsFactory = new RecipeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name RecipeCategories</summary>
			public static readonly string RecipeCategories = "RecipeCategories";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class RecipeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public RecipeEntityStaticMetaData()
			{
				SetEntityCoreInfo("RecipeEntity", InheritanceHierarchyType.None, false, (int)HomeRecipes_UserRoles_v1.EntityType.RecipeEntity, typeof(RecipeEntity), typeof(RecipeEntityFactory), false);
				AddNavigatorMetaData<RecipeEntity, EntityCollection<RecipeCategoryEntity>>("RecipeCategories", a => a._recipeCategories, (a, b) => a._recipeCategories = b, a => a.RecipeCategories, () => new RecipeRelations().RecipeCategoryEntityUsingRecipeId, typeof(RecipeCategoryEntity), (int)HomeRecipes_UserRoles_v1.EntityType.RecipeCategoryEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static RecipeEntity()
		{
		}

		/// <summary> CTor</summary>
		public RecipeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RecipeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RecipeEntity</param>
		public RecipeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Recipe which data should be fetched into this Recipe object</param>
		public RecipeEntity(System.Guid id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Recipe which data should be fetched into this Recipe object</param>
		/// <param name="validator">The custom validator object for this RecipeEntity</param>
		public RecipeEntity(System.Guid id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RecipeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'RecipeCategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecipeCategories() { return CreateRelationInfoForNavigator("RecipeCategories"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this RecipeEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static RecipeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecipeCategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecipeCategories { get { return _staticMetaData.GetPrefetchPathElement("RecipeCategories", CommonEntityBase.CreateEntityCollection<RecipeCategoryEntity>()); } }

		/// <summary>The Id property of the Entity Recipe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Recipe"."id".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)RecipeFieldIndex.Id, true); }
			set	{ SetValue((int)RecipeFieldIndex.Id, value); }
		}

		/// <summary>The Ingredients property of the Entity Recipe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Recipe"."ingredients".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Ingredients
		{
			get { return (System.String)GetValue((int)RecipeFieldIndex.Ingredients, true); }
			set	{ SetValue((int)RecipeFieldIndex.Ingredients, value); }
		}

		/// <summary>The Instructions property of the Entity Recipe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Recipe"."instructions".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Instructions
		{
			get { return (System.String)GetValue((int)RecipeFieldIndex.Instructions, true); }
			set	{ SetValue((int)RecipeFieldIndex.Instructions, value); }
		}

		/// <summary>The IsActive property of the Entity Recipe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Recipe"."is_active".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)RecipeFieldIndex.IsActive, true); }
			set	{ SetValue((int)RecipeFieldIndex.IsActive, value); }
		}

		/// <summary>The Title property of the Entity Recipe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Recipe"."title".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)RecipeFieldIndex.Title, true); }
			set	{ SetValue((int)RecipeFieldIndex.Title, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'RecipeCategoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RecipeCategoryEntity))]
		public virtual EntityCollection<RecipeCategoryEntity> RecipeCategories { get { return GetOrCreateEntityCollection<RecipeCategoryEntity, RecipeCategoryEntityFactory>("Recipe", true, false, ref _recipeCategories); } }
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace HomeRecipes_UserRoles_v1
{
	public enum RecipeFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Ingredients. </summary>
		Ingredients,
		///<summary>Instructions. </summary>
		Instructions,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace HomeRecipes_UserRoles_v1.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Recipe. </summary>
	public partial class RecipeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between RecipeEntity and RecipeCategoryEntity over the 1:n relation they have, using the relation between the fields: Recipe.Id - RecipeCategory.RecipeId</summary>
		public virtual IEntityRelation RecipeCategoryEntityUsingRecipeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "RecipeCategories", true, new[] { RecipeFields.Id, RecipeCategoryFields.RecipeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticRecipeRelations
	{
		internal static readonly IEntityRelation RecipeCategoryEntityUsingRecipeIdStatic = new RecipeRelations().RecipeCategoryEntityUsingRecipeId;

		/// <summary>CTor</summary>
		static StaticRecipeRelations() { }
	}
}