<a name='assembly'></a>
# ExerciceDocumentation

## Contents

- [DataProvider](#T-ExerciceDocumentation-DataProvider 'ExerciceDocumentation.DataProvider')
  - [DataCollection](#P-ExerciceDocumentation-DataProvider-DataCollection 'ExerciceDocumentation.DataProvider.DataCollection')

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

Vous pouvez accéder à toute les données avec une liste de string:

```
    foreach (var data in data.GetAllData()
    {
        lstDisplay.Items.Add(data);
    }
```

ou recevoir une ligne de données directement avec son index.:

```
lstDisplay.Items.Add(data.GetSingleLineOfData(3)
```
