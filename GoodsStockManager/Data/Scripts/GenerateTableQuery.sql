CREATE TABLE [dbo].[Goods] (
    [Code]               NVARCHAR (25)  NOT NULL,
    [Description]        NVARCHAR (300) NOT NULL,
    [IsActive]           BIT            NOT NULL,
    [ForeignDescription] NVARCHAR (300) NULL,
    [IsSalesItem]        BIT            NOT NULL,
    [IsStockItem]        BIT            NOT NULL,
    [IsPurchasedItem]    BIT            NOT NULL,
    [Barcode]            NVARCHAR (100) NOT NULL,
    [ManageItemBy]       INT            NOT NULL,
    [MinimumInventory]   DECIMAL (18)   NOT NULL,
    [MaximumInventory]   DECIMAL (18)   NOT NULL,
    [Remarks]            NVARCHAR (MAX) NULL,
    [ImagePath]          NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Code] ASC)
);