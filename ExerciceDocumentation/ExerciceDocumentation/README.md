<a name='assembly'></a>
# ExerciceDocumentation

## Contents

- [DataProvider](#T-ExerciceDocumentation-DataProvider 'ExerciceDocumentation.DataProvider')
  - [DataCollection](#P-ExerciceDocumentation-DataProvider-DataCollection 'ExerciceDocumentation.DataProvider.DataCollection')
  - [GetAllData()](#M-ExerciceDocumentation-DataProvider-GetAllData 'ExerciceDocumentation.DataProvider.GetAllData')
  - [GetSingleLineOfData(indexOfData)](#M-ExerciceDocumentation-DataProvider-GetSingleLineOfData-System-Int32- 'ExerciceDocumentation.DataProvider.GetSingleLineOfData(System.Int32)')

<a name='T-ExerciceDocumentation-DataProvider'></a>
## DataProvider `type`

##### Namespace

ExerciceDocumentation

<a name='P-ExerciceDocumentation-DataProvider-DataCollection'></a>
### DataCollection `property`

##### Summary

Cette classe est utilisée dans le contexte d'un exercice pour se pratiquer à créer de la documentation.

Le DataProvider permet d'accéder à des données à partir d'une base de données de type SQLServer.
Pour l'initialiser, vous devez avoir en main votre connection string. Vous pouvez initialiser la classe de cette manière:

```
    DataProvider data = new DataProvider("connexionAVotreDb");
```

<a name='M-ExerciceDocumentation-DataProvider-GetAllData'></a>
### GetAllData() `method`

##### Summary

Vous pouvez accéder à toute les données avec une liste de string:

```
    foreach (var data in data.GetAllData()
    {
        lstDisplay.Items.Add(data);
    }
```

##### Returns

Cette fonction retourne toute la base de données sous forme de liste de string.

##### Parameters

This method has no parameters.

<a name='M-ExerciceDocumentation-DataProvider-GetSingleLineOfData-System-Int32-'></a>
### GetSingleLineOfData(indexOfData) `method`

##### Summary

Cette fonction sert à itérer une seule ligne de notre base de données. Elle s'appelle de cette façon:

```
lstDisplay.Items.Add(data.GetSingleLineOfData(3));
```

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| indexOfData | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | L'index de la ligne a itérer. |
