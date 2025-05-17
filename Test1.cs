using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq; 
using System.Collections.Generic;
using Laba_12;
using MusicInstrumentLibr;
using System.Reflection;


namespace TestLab12
{
    [TestClass]
    public class DoublyLinkedListTests
    {
        //    //Вспомогательные методы
        //    private Guitar CreateTestGuitar(string name = "TestGuitar", int id = 1, int strings = 6)
        //    {
        //        return new Guitar(name, id, strings);
        //    }

        //    private Piano CreateTestPiano(string name = "TestPiano", int id = 2, int keys = 88)
        //    {
        //        return new Piano(name, id, "Октавная", keys);
        //    }

        //    private ElectricGuitar CreateTestElectricGuitar(string name = "TestEGuitar", int id = 3, int strings = 7, string power = "Аккумулятор")
        //    {
        //        return new ElectricGuitar(name, id, strings, power);
        //    }

        //    //Тесты конструктора и свойств

        //    [TestMethod]
        //    public void Constructor_Default_CreatesEmptyList()
        //    {
        //        // Arrange & Act
        //        var list = new DoublyLinkedList<MusicInstrument>();

        //        // Assert
        //        Assert.AreEqual(0, list.Count, "Count должен быть 0 для нового списка.");
        //        Assert.IsTrue(list.IsEmpty, "IsEmpty должен быть true для нового списка.");
        //    }

        //    //Тесты AddLast

        //    [TestMethod]
        //    public void AddLast_ToEmptyList_AddsElementCorrectly()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar = CreateTestGuitar();

        //        // Act
        //        list.AddLast(guitar);

        //        // Assert
        //        Assert.AreEqual(1, list.Count, "Count должен быть 1 после добавления.");
        //        Assert.IsFalse(list.IsEmpty, "IsEmpty должен быть false после добавления.");
        //        // Проверяем, что элемент действительно добавлен (используем GetEnumerator)
        //        Assert.AreSame(guitar, list.First(), "Добавленный элемент должен быть в списке.");
        //    }

        //    [TestMethod]
        //    public void AddLast_ToNonEmptyList_AddsElementToEnd()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar1 = CreateTestGuitar("G1", 1);
        //        var piano1 = CreateTestPiano("P1", 2);
        //        list.AddLast(guitar1);

        //        // Act
        //        list.AddLast(piano1); // Добавляем второй элемент

        //        // Assert
        //        Assert.AreEqual(2, list.Count, "Count должен быть 2.");
        //        Assert.AreSame(piano1, list.Last(), "Последний добавленный элемент должен быть в конце.");
        //        Assert.AreSame(guitar1, list.First(), "Первый элемент должен остаться первым.");
        //    }

        //    //Тесты AddFirst

        //    [TestMethod]
        //    public void AddFirst_ToEmptyList_AddsElementCorrectly()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var piano = CreateTestPiano();

        //        // Act
        //        list.AddFirst(piano);

        //        // Assert
        //        Assert.AreEqual(1, list.Count, "Count должен быть 1.");
        //        Assert.IsFalse(list.IsEmpty, "IsEmpty должен быть false.");
        //        Assert.AreSame(piano, list.First(), "Добавленный элемент должен быть первым.");
        //        Assert.AreSame(piano, list.Last(), "Добавленный элемент должен быть последним (т.к. он единственный).");
        //    }

        //    [TestMethod]
        //    public void AddFirst_ToNonEmptyList_AddsElementToBeginning()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar1 = CreateTestGuitar("G1", 1);
        //        var piano1 = CreateTestPiano("P1", 2);
        //        list.AddLast(guitar1); // Сначала добавляем гитару

        //        // Act
        //        list.AddFirst(piano1); // Добавляем пианино в начало

        //        // Assert
        //        Assert.AreEqual(2, list.Count, "Count должен быть 2.");
        //        Assert.AreSame(piano1, list.First(), "Добавленный элемент должен быть первым.");
        //        Assert.AreSame(guitar1, list.Last(), "Исходный элемент должен стать последним.");
        //    }

        //    //Тесты AddAt

        //    [TestMethod]
        //    public void AddAt_IndexZero_AddsToBeginning()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar1 = CreateTestGuitar("G1", 1);
        //        var piano1 = CreateTestPiano("P1", 2);
        //        list.AddLast(guitar1);

        //        // Act
        //        list.AddAt(piano1, 0); // Вставляем по индексу 0

        //        // Assert
        //        Assert.AreEqual(2, list.Count, "Count должен быть 2.");
        //        Assert.AreSame(piano1, list.First(), "Добавленный элемент должен быть первым.");
        //        Assert.AreSame(guitar1, list.ElementAt(1), "Исходный элемент должен быть вторым."); // Используем ElementAt для проверки
        //    }

        //    [TestMethod]
        //    public void AddAt_IndexCount_AddsToEnd()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar1 = CreateTestGuitar("G1", 1);
        //        var piano1 = CreateTestPiano("P1", 2);
        //        list.AddLast(guitar1);

        //        // Act
        //        list.AddAt(piano1, 1); // Вставляем по индексу Count (равному 1)

        //        // Assert
        //        Assert.AreEqual(2, list.Count, "Count должен быть 2.");
        //        Assert.AreSame(piano1, list.Last(), "Добавленный элемент должен быть последним.");
        //        Assert.AreSame(guitar1, list.First(), "Исходный элемент должен остаться первым.");
        //    }

        //    [TestMethod]
        //    public void AddAt_MiddleIndex_AddsCorrectly()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar1 = CreateTestGuitar("G1", 1);
        //        var piano1 = CreateTestPiano("P1", 2);
        //        var eguitar1 = CreateTestElectricGuitar("EG1", 3);
        //        list.AddLast(guitar1);
        //        list.AddLast(piano1); // Список: G1, P1

        //        // Act
        //        list.AddAt(eguitar1, 1); // Вставляем по индексу 1

        //        // Assert
        //        Assert.AreEqual(3, list.Count, "Count должен быть 3.");
        //        Assert.AreSame(guitar1, list.ElementAt(0), "Первый элемент.");
        //        Assert.AreSame(eguitar1, list.ElementAt(1), "Вставленный элемент.");
        //        Assert.AreSame(piano1, list.ElementAt(2), "Последний элемент.");
        //    }

        //    [TestMethod]
        //    public void AddAt_InvalidIndexLow_ThrowsArgumentOutOfRangeException()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar1 = CreateTestGuitar();

        //        // Act & Assert
        //        Assert.ThrowsException<ArgumentOutOfRangeException>(() => list.AddAt(guitar1, -1),
        //            "Должно выбрасываться исключение для индекса < 0.");
        //    }

        //    [TestMethod]
        //    public void AddAt_InvalidIndexHigh_ThrowsArgumentOutOfRangeException()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar1 = CreateTestGuitar("G1", 1);
        //        var piano1 = CreateTestPiano("P1", 2);
        //        list.AddLast(guitar1);

        //        // Act & Assert
        //        Assert.ThrowsException<ArgumentOutOfRangeException>(() => list.AddAt(piano1, 2), // Count = 1, индекс 2 недопустим
        //            "Должно выбрасываться исключение для индекса > Count.");
        //    }

        //    //Тесты Clear

        //    [TestMethod]
        //    public void Clear_NonEmptyList_MakesListEmpty()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        list.AddLast(CreateTestGuitar());
        //        list.AddLast(CreateTestPiano());

        //        // Act
        //        list.Clear();

        //        // Assert
        //        Assert.AreEqual(0, list.Count, "Count должен быть 0 после Clear.");
        //        Assert.IsTrue(list.IsEmpty, "IsEmpty должен быть true после Clear.");
        //        // Убедимся, что перебор пустого списка не вызывает ошибок
        //        Assert.AreEqual(0, list.Count(), "Перебор через LINQ Count() должен вернуть 0.");
        //    }

        //    [TestMethod]
        //    public void Clear_EmptyList_RemainsEmpty()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();

        //        // Act
        //        list.Clear();

        //        // Assert
        //        Assert.AreEqual(0, list.Count, "Count должен остаться 0.");
        //        Assert.IsTrue(list.IsEmpty, "IsEmpty должен остаться true.");
        //    }

        //    //Тесты FindNode

        //    [TestMethod]
        //    public void FindNode_ElementExists_ReturnsNode()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar1 = CreateTestGuitar("FindMe", 10);
        //        var piano1 = CreateTestPiano("P1", 11);
        //        list.AddLast(piano1);
        //        list.AddLast(guitar1); // FindMe - второй элемент

        //        // Act
        //        // Ищем по имени "FindMe" без учета регистра
        //        Point<MusicInstrument> foundNode = list.FindNode(instr => instr.Name.Equals("findme", StringComparison.OrdinalIgnoreCase));

        //        // Assert
        //        Assert.IsNotNull(foundNode, "Узел должен быть найден.");
        //        Assert.AreSame(guitar1, foundNode.Data, "Найденный узел должен содержать искомый объект.");
        //    }

        //    [TestMethod]
        //    public void FindNode_ElementDoesNotExist_ReturnsNull()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar1 = CreateTestGuitar("G1", 1);
        //        var piano1 = CreateTestPiano("P1", 2);
        //        list.AddLast(guitar1);
        //        list.AddLast(piano1);

        //        // Act
        //        // Ищем несуществующее имя
        //        Point<MusicInstrument> foundNode = list.FindNode(instr => instr.Name == "NotFound");

        //        // Assert
        //        Assert.IsNull(foundNode, "Узел не должен быть найден.");
        //    }

        //    [TestMethod]
        //    public void FindNode_FirstElementMatches_ReturnsNode()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var guitar1 = CreateTestGuitar("First", 10);
        //        var piano1 = CreateTestPiano("P1", 11);
        //        list.AddLast(guitar1); // Искомый - первый
        //        list.AddLast(piano1);

        //        // Act
        //        Point<MusicInstrument> foundNode = list.FindNode(instr => instr.Name == "First");

        //        // Assert
        //        Assert.IsNotNull(foundNode, "Узел должен быть найден.");
        //        Assert.AreSame(guitar1, foundNode.Data, "Найденный узел должен быть первым.");
        //    }

        //    [TestMethod]
        //    public void FindNode_EmptyList_ReturnsNull()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();

        //        // Act
        //        Point<MusicInstrument> foundNode = list.FindNode(instr => instr.Name == "Any");

        //        // Assert
        //        Assert.IsNull(foundNode, "Поиск в пустом списке должен вернуть null.");
        //    }

        //    [TestMethod]
        //    public void FindNode_NullPredicate_ThrowsArgumentNullException()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        list.AddLast(CreateTestGuitar());

        //        // Act & Assert
        //        Assert.ThrowsException<ArgumentNullException>(() => list.FindNode(null),
        //            "Должно выбрасываться исключение для null предиката.");
        //    }

        //    //Тесты RemoveAfter

        //    [TestMethod]
        //    public void RemoveAfter_NodeInMiddle_RemovesSubsequentNodesAndUpdatesCount()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var g1 = CreateTestGuitar("G1", 1);
        //        var p1 = CreateTestPiano("P1", 2); // Узел, после которого удаляем
        //        var eg1 = CreateTestElectricGuitar("EG1", 3); // Удаляемый
        //        var g2 = CreateTestGuitar("G2", 4);       // Удаляемый
        //        list.AddLast(g1);
        //        list.AddLast(p1);
        //        list.AddLast(eg1);
        //        list.AddLast(g2); // Список: G1, P1, EG1, G2 (Count = 4)

        //        // Находим узел p1
        //        Point<MusicInstrument> nodeToRemoveAfter = list.FindNode(instr => instr.Id.Number == 2);
        //        Assert.IsNotNull(nodeToRemoveAfter, "Узел для RemoveAfter должен быть найден.");

        //        // Act
        //        bool result = list.RemoveFromNameToEnd(nodeToRemoveAfter);

        //        // Assert
        //        Assert.IsTrue(result, "RemoveAfter должен вернуть true, т.к. узел не был хвостом.");
        //        Assert.AreEqual(2, list.Count, "Count должен стать 2.");
        //        Assert.AreSame(p1, list.Last(), "Узел p1 должен стать новым хвостом.");
        //        // Проверяем оставшиеся элементы
        //        var remaining = list.ToList();
        //        Assert.AreEqual(2, remaining.Count);
        //        Assert.AreSame(g1, remaining[0]);
        //        Assert.AreSame(p1, remaining[1]);
        //    }

        //    [TestMethod]
        //    public void RemoveAfter_NodeIsHead_RemovesSubsequentNodes()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var g1 = CreateTestGuitar("G1", 1); // Узел, после которого удаляем (он же head)
        //        var p1 = CreateTestPiano("P1", 2);
        //        var eg1 = CreateTestElectricGuitar("EG1", 3);
        //        list.AddLast(g1);
        //        list.AddLast(p1);
        //        list.AddLast(eg1); // Список: G1, P1, EG1 (Count = 3)

        //        // Находим узел g1 (head)
        //        Point<MusicInstrument> nodeToRemoveAfter = list.FindNode(instr => instr.Id.Number == 1);
        //        Assert.IsNotNull(nodeToRemoveAfter, "Узел для RemoveAfter (head) должен быть найден.");

        //        // Act
        //        bool result = list.RemoveFromNameToEnd(nodeToRemoveAfter);

        //        // Assert
        //        Assert.IsTrue(result, "RemoveAfter должен вернуть true.");
        //        Assert.AreEqual(1, list.Count, "Count должен стать 1.");
        //        Assert.AreSame(g1, list.First(), "Узел g1 должен остаться головой.");
        //        Assert.AreSame(g1, list.Last(), "Узел g1 должен стать хвостом.");
        //        Assert.AreEqual(1, list.Count()); // Проверка перебором
        //    }


        //    [TestMethod]
        //    public void RemoveAfter_NodeIsTail_ReturnsFalseAndListUnchanged()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var g1 = CreateTestGuitar("G1", 1);
        //        var p1 = CreateTestPiano("P1", 2); // Узел хвоста
        //        list.AddLast(g1);
        //        list.AddLast(p1); // Список: G1, P1 (Count = 2)
        //        var initialElements = list.ToList(); // Сохраняем исходные элементы

        //        // Находим узел p1 (tail)
        //        Point<MusicInstrument> nodeToRemoveAfter = list.FindNode(instr => instr.Id.Number == 2);
        //        Assert.IsNotNull(nodeToRemoveAfter, "Узел для RemoveAfter (tail) должен быть найден.");

        //        // Act
        //        bool result = list.RemoveFromNameToEnd(nodeToRemoveAfter);

        //        // Assert
        //        Assert.IsFalse(result, "RemoveAfter должен вернуть false, т.к. узел является хвостом.");
        //        Assert.AreEqual(2, list.Count, "Count не должен измениться.");
        //        // Проверяем, что элементы остались прежними
        //        CollectionAssert.AreEqual(initialElements, list.ToList(), "Элементы списка не должны измениться.");
        //    }

        //    [TestMethod]
        //    public void RemoveAfter_NullNode_ReturnsFalseAndListUnchanged()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var g1 = CreateTestGuitar("G1", 1);
        //        list.AddLast(g1);
        //        var initialElements = list.ToList();
        //        int initialCount = list.Count;

        //        // Act
        //        bool result = list.RemoveFromNameToEnd(null);

        //        // Assert
        //        Assert.IsFalse(result, "RemoveAfter должен вернуть false для null узла.");
        //        Assert.AreEqual(initialCount, list.Count, "Count не должен измениться.");
        //        CollectionAssert.AreEqual(initialElements, list.ToList(), "Элементы списка не должны измениться.");
        //    }

        //    [TestMethod]
        //    public void RemoveAfter_ListBecomesEmpty_HandlesCorrectly()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var g1 = CreateTestGuitar("G1", 1); // Узел, после которого удаляем (он же head)
        //        list.AddLast(g1); // Список: G1 (Count = 1)

        //        // Находим узел g1 (head)
        //        Point<MusicInstrument> nodeToRemoveAfter = list.FindNode(instr => instr.Id.Number == 1);
        //        Assert.IsNotNull(nodeToRemoveAfter, "Узел для RemoveAfter (head) должен быть найден.");

        //        // Act: Пытаемся удалить после единственного элемента. Он хвост, поэтому ничего не удалится.
        //        bool result = list.RemoveFromNameToEnd(nodeToRemoveAfter);

        //        // Assert
        //        Assert.IsFalse(result, "RemoveAfter должен вернуть false, т.к. узел - хвост.");
        //        Assert.AreEqual(1, list.Count, "Count должен остаться 1.");
        //        Assert.AreSame(g1, list.First(), "Узел g1 должен остаться головой.");
        //        Assert.AreSame(g1, list.Last(), "Узел g1 должен остаться хвостом.");
        //    }


        //    //Тесты DeepClone

        //    [TestMethod]
        //    public void DeepClone_EmptyList_ReturnsEmptyList()
        //    {
        //        // Arrange
        //        var originalList = new DoublyLinkedList<MusicInstrument>();

        //        // Act
        //        var clonedList = originalList.DeepClone();

        //        // Assert
        //        Assert.IsNotNull(clonedList, "Клонированный список не должен быть null.");
        //        Assert.AreNotSame(originalList, clonedList, "Клон должен быть новым объектом списка.");
        //        Assert.AreEqual(0, clonedList.Count, "Клонированный список должен быть пустым.");
        //        Assert.IsTrue(clonedList.IsEmpty, "IsEmpty клона должен быть true.");
        //    }

        //    [TestMethod]
        //    public void DeepClone_NonEmptyList_CreatesIndependentCopyOfListAndElements()
        //    {
        //        // Arrange
        //        var originalList = new DoublyLinkedList<MusicInstrument>();
        //        var g1 = CreateTestGuitar("G1", 1);
        //        var p1 = CreateTestPiano("P1", 2);
        //        originalList.AddLast(g1);
        //        originalList.AddLast(p1);

        //        // Act
        //        var clonedList = originalList.DeepClone();

        //        // Assert
        //        // 1. Проверка самого списка
        //        Assert.IsNotNull(clonedList, "Клон не должен быть null.");
        //        Assert.AreNotSame(originalList, clonedList, "Клон должен быть новым объектом списка.");
        //        Assert.AreEqual(originalList.Count, clonedList.Count, "Количество элементов должно совпадать.");

        //        // 2. Проверка элементов
        //        var originalElements = originalList.ToList();
        //        var clonedElements = clonedList.ToList();

        //        for (int i = 0; i < originalList.Count; i++)
        //        {
        //            // Данные должны быть равны по значению (Equals)
        //            Assert.AreEqual(originalElements[i], clonedElements[i], $"Элемент {i} должен быть равен по значению.");
        //            // Но ссылки на объекты данных должны быть разными (глубокое копирование)
        //            Assert.AreNotSame(originalElements[i], clonedElements[i], $"Элемент {i} должен быть новым объектом (другой ссылкой).");
        //            // Дополнительно проверим Id (т.к. он тоже должен был глубоко скопироваться)
        //            Assert.AreEqual(originalElements[i].Id.Number, clonedElements[i].Id.Number, $"Id элемента {i} должен быть равен по значению.");
        //            Assert.AreNotSame(originalElements[i].Id, clonedElements[i].Id, $"Id элемента {i} должен быть новым объектом (другой ссылкой).");
        //        }

        //        // 3. Проверка независимости
        //        // Изменяем объект в оригинальном списке
        //        originalElements[0].Name = "ModifiedG1";
        //        // Проверяем, что соответствующий объект в клоне не изменился
        //        Assert.AreNotEqual(originalElements[0].Name, clonedElements[0].Name, "Изменение оригинала не должно влиять на клон.");
        //        Assert.AreEqual("G1", clonedElements[0].Name, "Имя в клоне должно остаться 'G1'.");

        //        // Добавляем элемент в оригинальный список
        //        originalList.AddLast(CreateTestElectricGuitar());
        //        // Проверяем, что размер клона не изменился
        //        Assert.AreEqual(2, clonedList.Count, "Добавление в оригинал не должно влиять на размер клона.");
        //    }

        //    //Nесты GetEnumerator (неявно проверяются в других тестах через LINQ)

        //    [TestMethod]
        //    public void GetEnumerator_ForEachLoop_IteratesCorrectly()
        //    {
        //        // Arrange
        //        var list = new DoublyLinkedList<MusicInstrument>();
        //        var g1 = CreateTestGuitar("G1", 1);
        //        var p1 = CreateTestPiano("P1", 2);
        //        var eg1 = CreateTestElectricGuitar("EG1", 3);
        //        var expectedOrder = new List<MusicInstrument> { g1, p1, eg1 };
        //        list.AddLast(g1);
        //        list.AddLast(p1);
        //        list.AddLast(eg1);

        //        var actualOrder = new List<MusicInstrument>();

        //        // Act
        //        foreach (var instrument in list)
        //        {
        //            actualOrder.Add(instrument);
        //        }

        //        // Assert
        //        CollectionAssert.AreEqual(expectedOrder, actualOrder, "Порядок элементов при переборе foreach должен быть верным.");
        //    }
    }
    [TestClass]
    public class HashNodeTests
    {
        [TestMethod]
        public void GetHashCode_ValidKey_ReturnsSumOfCharCodes()
        {
            // Arrange
            string key = "Guitar1"; //G=71, u=117, i=105, t=116, a=97, r=114, 1=49 -> 71+117+105+116+97+114+49=669
            var instrument = new Guitar("Guitar1", 101, 6);
            var node = new HashNode<MusicInstrument>(key, instrument);

            // Act
            int hash = node.GetHashCode();

            // Assert
            Assert.AreEqual(669, hash);
        }

        [TestMethod]
        public void GetHashCode_NullKey_ReturnsZero()
        {
            // Arrange
            var instrument = new Guitar("Guitar1", 101, 6);
            var node = new HashNode<MusicInstrument>(null, instrument);

            // Act
            int hash = node.GetHashCode();

            // Assert
            Assert.AreEqual(0, hash);
        }

        [TestMethod]
        public void Equals_SameKey_ReturnsTrue()
        {
            // Arrange
            var instrument1 = new Guitar("Guitar1", 101, 6);
            var instrument2 = new Piano("Piano1", 102, "Октавная", 88);
            var node1 = new HashNode<MusicInstrument>("key", instrument1);
            var node2 = new HashNode<MusicInstrument>("key", instrument2);

            // Act
            bool areEqual = node1.Equals(node2);

            // Assert
            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void Equals_DifferentKey_ReturnsFalse()
        {
            // Arrange
            var instrument1 = new Guitar("Guitar1", 101, 6);
            var instrument2 = new Piano("Piano1", 102, "Октавная", 88);
            var node1 = new HashNode<MusicInstrument>("key1", instrument1);
            var node2 = new HashNode<MusicInstrument>("key2", instrument2);

            // Act
            bool areEqual = node1.Equals(node2);

            // Assert
            Assert.IsFalse(areEqual);
        }

        [TestMethod]
        public void Equals_NullObject_ReturnsFalse()
        {
            // Arrange
            var instrument = new Guitar("Guitar1", 101, 6);
            var node = new HashNode<MusicInstrument>("key", instrument);

            // Act
            bool areEqual = node.Equals(null);

            // Assert
            Assert.IsFalse(areEqual);
        }

        [TestMethod]
        public void Equals_DifferentType_ReturnsFalse()
        {
            // Arrange
            var instrument = new Guitar("Guitar1", 101, 6);
            var node = new HashNode<MusicInstrument>("key", instrument);
            var other = new object();

            // Act
            bool areEqual = node.Equals(other);

            // Assert
            Assert.IsFalse(areEqual);
        }

        [TestMethod]
        public void ToString_ValidNode_ReturnsKeyValueString()
        {
            // Arrange
            var instrument = new Guitar("Guitar1", 101, 6);
            var node = new HashNode<MusicInstrument>("Guitar1", instrument);

            // Act
            string result = node.ToString();

            // Assert
            Assert.AreEqual("Key: Guitar1, Value: Имя гитары: Guitar1, Id: Id: 101, Количество струн: 6", result);
        }
    }

    [TestClass]
    public class HashTableTests
    {
        private HashTable<MusicInstrument> CreateTable()
        {
            return new HashTable<MusicInstrument>(5);
        }

        [TestMethod]
        public void Add_NewKey_ReturnsTrueAndAddsElement()
        {
            // Arrange
            var table = CreateTable();
            var instrument = new Guitar("Guitar1", 101, 6);

            // Act
            bool result = table.Add("Guitar1", instrument);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(1, table.Count);
            var found = table.Find("Guitar1");
            Assert.IsNotNull(found);
            Assert.AreEqual("Guitar1", found.Name);
            Assert.AreEqual(101, found.Id.Number);
            Assert.AreNotSame(instrument, found); // Проверка глубокого клонирования
        }

        [TestMethod]
        public void Add_DuplicateKey_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();
            var instrument1 = new Guitar("Guitar1", 101, 6);
            var instrument2 = new Guitar("Guitar1", 102, 7);
            table.Add("Guitar1", instrument1);

            // Act
            bool result = table.Add("Guitar1", instrument2);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(1, table.Count);
            var found = table.Find("Guitar1");
            Assert.AreEqual(101, found.Id.Number); // Первый элемент остался
        }

        [TestMethod]
        public void Add_FullTable_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();
            // Хеши: Guitar1=669%5=4, Piano1=672%5=2, EGuitar1=885%5=0, Guitar2=670%5=0->1, Piano2=673%5=3
            table.Add("Guitar1", new Guitar("Guitar1", 101, 6));
            table.Add("Piano1", new Piano("Piano1", 102, "Октавная", 88));
            table.Add("EGuitar1", new ElectricGuitar("EGuitar1", 103, 7, "Аккумулятор"));
            table.Add("Guitar2", new Guitar("Guitar2", 104, 6));
            table.Add("Piano2", new Piano("Piano2", 105, "Октавная", 88));

            // Act
            bool result = table.Add("Drums1", new Guitar("Drums1", 106, 6));

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(5, table.Count);
            Assert.IsNull(table.Find("Drums1"));
        }

        [TestMethod]
        public void Add_Collision_ResolvesWithProbing()
        {
            // Arrange
            var table = CreateTable();
            var instrument1 = new Guitar("Guitar1", 101, 6); // Hash: 669 % 5 = 4
            var instrument2 = new Guitar("Guitar2", 102, 6); // Hash: 670 % 5 = 0

            // Act
            bool result1 = table.Add("Guitar1", instrument1);
            bool result2 = table.Add("Guitar2", instrument2);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.AreEqual(2, table.Count);
            Assert.IsNotNull(table.Find("Guitar1"));
            Assert.IsNotNull(table.Find("Guitar2"));
            Assert.AreNotSame(instrument1, table.Find("Guitar1"));
            Assert.AreNotSame(instrument2, table.Find("Guitar2"));
        }

        [TestMethod]
        public void Add_NullKey_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();
            var instrument = new Guitar("Guitar1", 101, 6);

            // Act
            bool result = table.Add(null, instrument);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(0, table.Count);
            Assert.IsNull(table.Find(null));
        }

        [TestMethod]
        public void AddAtIndex_ValidIndex_ReturnsTrueAndAddsElement()
        {
            // Arrange
            var table = CreateTable();
            var instrument = new Guitar("Guitar1", 101, 6);

            // Act
            bool result = table.AddAtIndex("Guitar1", instrument, 4);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(1, table.Count);
            var found = table.Find("Guitar1");
            Assert.IsNotNull(found);
            Assert.AreEqual("Guitar1", found.Name);
            Assert.AreNotSame(instrument, found);
        }

        [TestMethod]
        public void AddAtIndex_OccupiedIndex_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();
            var instrument1 = new Guitar("Guitar1", 101, 6);
            var instrument2 = new Piano("Piano1", 102, "Октавная", 88);
            table.AddAtIndex("Guitar1", instrument1, 4);

            // Act
            bool result = table.AddAtIndex("Piano1", instrument2, 4);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(1, table.Count);
            Assert.IsNull(table.Find("Piano1"));
        }

        [TestMethod]
        public void AddAtIndex_InvalidIndex_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();
            var instrument = new Guitar("Guitar1", 101, 6);

            // Act
            bool result = table.AddAtIndex("Guitar1", instrument, 5);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(0, table.Count);
            Assert.IsNull(table.Find("Guitar1"));
        }

        [TestMethod]
        public void AddAtIndex_DuplicateKey_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();
            var instrument1 = new Guitar("Guitar1", 101, 6);
            var instrument2 = new Guitar("Guitar1", 102, 7);
            table.AddAtIndex("Guitar1", instrument1, 4);

            // Act
            bool result = table.AddAtIndex("Guitar1", instrument2, 4);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(1, table.Count);
            var found = table.Find("Guitar1");
            Assert.AreEqual(101, found.Id.Number);
        }

        [TestMethod]
        public void AddAtIndex_FullTable_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();
            table.AddAtIndex("Guitar1", new Guitar("Guitar1", 101, 6), 0);
            table.AddAtIndex("Piano1", new Piano("Piano1", 102, "Октавная", 88), 1);
            table.AddAtIndex("EGuitar1", new ElectricGuitar("EGuitar1", 103, 7, "Аккумулятор"), 2);
            table.AddAtIndex("Guitar2", new Guitar("Guitar2", 104, 6), 3);
            table.AddAtIndex("Piano2", new Piano("Piano2", 105, "Октавная", 88), 4);

            // Act
            bool result = table.AddAtIndex("Drums1", new Guitar("Drums1", 106, 6), 0);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(5, table.Count);
            Assert.IsNull(table.Find("Drums1"));
        }

        [TestMethod]
        public void Find_ExistingKey_ReturnsClonedValue()
        {
            // Arrange
            var table = CreateTable();
            var instrument = new Guitar("Guitar1", 101, 6);
            table.Add("Guitar1", instrument);

            // Act
            var result = table.Find("Guitar1");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Guitar1", result.Name);
            Assert.AreEqual(101, result.Id.Number);
            Assert.AreNotSame(instrument, result);
        }

        [TestMethod]
        public void Find_NonExistingKey_ReturnsNull()
        {
            // Arrange
            var table = CreateTable();

            // Act
            var result = table.Find("Guitar1");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Find_DeletedKey_ReturnsNull()
        {
            // Arrange
            var table = CreateTable();
            var instrument = new Guitar("Guitar1", 101, 6);
            table.Add("Guitar1", instrument);
            table.Remove("Guitar1");

            // Act
            var result = table.Find("Guitar1");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Find_NullKey_ReturnsNull()
        {
            // Arrange
            var table = CreateTable();
            var instrument = new Guitar("Guitar1", 101, 6);
            table.Add("Guitar1", instrument);

            // Act
            var result = table.Find(null);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Remove_ExistingKey_ReturnsTrueAndRemovesElement()
        {
            // Arrange
            var table = CreateTable();
            var instrument = new Guitar("Guitar1", 101, 6);
            table.Add("Guitar1", instrument);

            // Act
            bool result = table.Remove("Guitar1");

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(0, table.Count);
            Assert.IsNull(table.Find("Guitar1"));
        }

        [TestMethod]
        public void Remove_NonExistingKey_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();

            // Act
            bool result = table.Remove("Guitar1");

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(0, table.Count);
        }

        [TestMethod]
        public void Remove_DeletedKey_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();
            var instrument = new Guitar("Guitar1", 101, 6);
            table.Add("Guitar1", instrument);
            table.Remove("Guitar1");

            // Act
            bool result = table.Remove("Guitar1");

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(0, table.Count);
        }

        [TestMethod]
        public void Remove_NullKey_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();
            var instrument = new Guitar("Guitar1", 101, 6);
            table.Add("Guitar1", instrument);

            // Act
            bool result = table.Remove(null);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(1, table.Count);
        }

        [TestMethod]
        public void IsFull_EmptyTable_ReturnsFalse()
        {
            // Arrange
            var table = CreateTable();

            // Act
            bool result = table.IsFull();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFull_FullTable_ReturnsTrue()
        {
            // Arrange
            var table = CreateTable();
            table.Add("Guitar1", new Guitar("Guitar1", 101, 6));
            table.Add("Piano1", new Piano("Piano1", 102, "Октавная", 88));
            table.Add("EGuitar1", new ElectricGuitar("EGuitar1", 103, 7, "Аккумулятор"));
            table.Add("Guitar2", new Guitar("Guitar2", 104, 6));
            table.Add("Piano2", new Piano("Piano2", 105, "Октавная", 88));

            // Act
            bool result = table.IsFull();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetEnumerator_NonEmptyTable_ReturnsClonedPairs()
        {
            // Arrange
            var table = CreateTable();
            var instrument1 = new Guitar("Guitar1", 101, 6);
            var instrument2 = new Piano("Piano1", 102, "Октавная", 88);
            table.Add("Guitar1", instrument1);
            table.Add("Piano1", instrument2);

            // Act
            var pairs = table.ToList();

            // Assert
            Assert.AreEqual(2, pairs.Count);
            var pair1 = pairs.FirstOrDefault(p => p.Key == "Guitar1");
            var pair2 = pairs.FirstOrDefault(p => p.Key == "Piano1");
            Assert.IsNotNull(pair1);
            Assert.IsNotNull(pair2);
            Assert.AreEqual("Guitar1", pair1.Value.Name);
            Assert.AreEqual("Piano1", pair2.Value.Name);
            Assert.AreNotSame(instrument1, pair1.Value);
            Assert.AreNotSame(instrument2, pair2.Value);
        }

        [TestMethod]
        public void GetEnumerator_EmptyTable_ReturnsEmpty()
        {
            // Arrange
            var table = CreateTable();

            // Act
            var pairs = table.ToList();

            // Assert
            Assert.AreEqual(0, pairs.Count);
        }

        [TestMethod]
        public void GetEnumerator_DeletedItems_SkipsDeleted()
        {
            // Arrange
            var table = CreateTable();
            var instrument1 = new Guitar("Guitar1", 101, 6);
            var instrument2 = new Piano("Piano1", 102, "Октавная", 88);
            table.Add("Guitar1", instrument1);
            table.Add("Piano1", instrument2);
            table.Remove("Guitar1");

            // Act
            var pairs = table.ToList();

            // Assert
            Assert.AreEqual(1, pairs.Count);
            Assert.IsTrue(pairs.Any(p => p.Key == "Piano1"));
            Assert.IsFalse(pairs.Any(p => p.Key == "Guitar1"));
            Assert.AreNotSame(instrument2, pairs.First().Value);
        }
    }

    // Вспомогательный класс для тестирования, реализующий необходимые интерфейсы
    // Добавляет простое int значение для удобства сравнения и предсказуемости в тестах.
    public class TestMusicInstrument : MusicInstrument
    {
        private int testValue;

        public int TestValue
        {
            get { return testValue; }
            set { testValue = value; }
        }

        // Конструктор по умолчанию
        public TestMusicInstrument() : base()
        {
            testValue = 0;
        }

        // Конструктор с параметрами
        public TestMusicInstrument(string name, int id, int testValue) : base(name, id)
        {
            this.testValue = testValue;
        }

        // Конструктор копирования для глубокого копирования
        public TestMusicInstrument(TestMusicInstrument other) : base(other)
        {
            this.testValue = other.testValue;
        }

        // Переопределение Clone для глубокого копирования
        public new object Clone()
        {
            return new TestMusicInstrument(this);
        }

        // Переопределение CompareTo для использования TestValue для сравнения
        public override int CompareTo(object obj)
        {
            if (obj is TestMusicInstrument other)
            {
                // Сравниваем по TestValue для предсказуемости в тестах
                return this.TestValue.CompareTo(other.TestValue);
            }
            // Или используем базовое сравнение по имени
            return base.CompareTo(obj);
        }

        // Переопределение Equals для сравнения по TestValue в дополнение к базовым полям
        public override bool Equals(object obj)
        {
            if (base.Equals(obj) && obj is TestMusicInstrument other)
            {
                return this.TestValue == other.TestValue;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id.Number}, TestValue: {TestValue}";
        }
    }


    [TestClass] // Атрибут MSTest для тестового класса
    public class BinaryTreeNodeTests
    {
        [TestMethod] // Атрибут MSTest для тестового метода
        public void BinaryTreeNode_Constructor_SetsDataAndChildrenToNull()
        {
            // Arrange
            var data = new TestMusicInstrument("TestNode", 1, 10);

            // Act
            var node = new BinaryTreeNode<TestMusicInstrument>(data);

            // Assert
            Assert.IsNotNull(node);
            Assert.IsNotNull(node.Data);
            Assert.AreEqual(data, node.Data); // Проверка равенства значений
            Assert.AreNotSame(data, node.Data); // Проверка глубокого копирования (новый объект)
            Assert.IsNull(node.Left);
            Assert.IsNull(node.Right);
        }

        [TestMethod]
        public void DeepClone_NodeWithoutChildren_ReturnsDeepClone()
        {
            // Arrange
            var originalData = new TestMusicInstrument("Original", 2, 20);
            var originalNode = new BinaryTreeNode<TestMusicInstrument>(originalData);

            // Act
            var clonedNode = originalNode.DeepClone();

            // Assert
            Assert.IsNotNull(clonedNode);
            Assert.AreNotSame(originalNode, clonedNode); // Клонированный узел - новый объект
            Assert.IsNotNull(clonedNode.Data);
            Assert.AreEqual(originalData, clonedNode.Data); // Значения данных равны
            Assert.AreNotSame(originalData, clonedNode.Data); // Объект данных - глубокая копия
            Assert.IsNull(clonedNode.Left);
            Assert.IsNull(clonedNode.Right);
        }

        [TestMethod]
        public void DeepClone_NodeWithChildren_ReturnsDeepCloneOfNodeAndSubtree()
        {
            // Arrange
            var parentData = new TestMusicInstrument("Parent", 3, 30);
            var leftData = new TestMusicInstrument("LeftChild", 4, 40);
            var rightData = new TestMusicInstrument("RightChild", 5, 50);

            var originalNode = new BinaryTreeNode<TestMusicInstrument>(parentData);
            originalNode.Left = new BinaryTreeNode<TestMusicInstrument>(leftData);
            originalNode.Right = new BinaryTreeNode<TestMusicInstrument>(rightData);

            // Act
            var clonedNode = originalNode.DeepClone();

            // Assert
            Assert.IsNotNull(clonedNode);
            Assert.AreNotSame(originalNode, clonedNode); // Клонированный узел - новый объект
            Assert.IsNotNull(clonedNode.Data);
            Assert.AreEqual(parentData, clonedNode.Data);
            Assert.AreNotSame(parentData, clonedNode.Data);

            Assert.IsNotNull(clonedNode.Left);
            Assert.AreNotSame(originalNode.Left, clonedNode.Left); // Клонированный левый потомок - новый объект
            Assert.IsNotNull(clonedNode.Left.Data);
            Assert.AreEqual(leftData, clonedNode.Left.Data);
            Assert.AreNotSame(leftData, clonedNode.Left.Data);

            Assert.IsNotNull(clonedNode.Right);
            Assert.AreNotSame(originalNode.Right, clonedNode.Right); // Клонированный правый потомок - новый объект
            Assert.IsNotNull(clonedNode.Right.Data);
            Assert.AreEqual(rightData, clonedNode.Right.Data);
            Assert.AreNotSame(rightData, clonedNode.Right.Data);
        }
    }


    [TestClass] // Атрибут MSTest для тестового класса
    public class BinaryTreeTests
    {
        private Func<TestMusicInstrument>? _generator;
        private List<TestMusicInstrument>? _generatedData;
        private int _generatorIndex;

        [TestInitialize] // Атрибут MSTest для метода инициализации перед каждым тестом
        public void Setup()
        {
            // Инициализация предсказуемых данных для генератора
            _generatedData = new List<TestMusicInstrument>
        {
            new TestMusicInstrument("Instrument_E", 105, 5), // Корень идеально сбалансированного дерева из 7 узлов
            new TestMusicInstrument("Instrument_B", 102, 2),
            new TestMusicInstrument("Instrument_G", 107, 7),
            new TestMusicInstrument("Instrument_A", 101, 1),
            new TestMusicInstrument("Instrument_D", 104, 4),
            new TestMusicInstrument("Instrument_F", 106, 6),
            new TestMusicInstrument("Instrument_C", 103, 3),
            new TestMusicInstrument("Instrument_H", 108, 8),
            new TestMusicInstrument("Instrument_I", 109, 9),
            new TestMusicInstrument("Instrument_J", 110, 10)
        };
            _generatorIndex = 0;

            // Создание функции-генератора, которая возвращает данные из списка последовательно
            _generator = () =>
            {
                if (_generatorIndex < _generatedData.Count)
                {
                    // Возвращаем клон для имитации генерации *новых* уникальных экземпляров при каждом вызове
                    return (TestMusicInstrument)_generatedData[_generatorIndex++].Clone();
                }
                throw new InvalidOperationException("Генератор исчерпал данные");
            };
        }

        // Вспомогательный метод для подсчета узлов в дереве
        private int CountNodes(BinaryTreeNode<TestMusicInstrument>? node)
        {
            if (node == null) return 0;
            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }

        // Вспомогательный метод для получения корня (с использованием рефлексии для приватного поля)
        // Обращение к приватным полям в тестах не рекомендуется, но здесь используется для проверки состояния дерева.
        private BinaryTreeNode<TestMusicInstrument>? GetRoot(BinaryTree<TestMusicInstrument> tree)
        {
            var rootField = typeof(BinaryTree<TestMusicInstrument>)
                                .GetField("root", BindingFlags.NonPublic | BindingFlags.Instance);
            return (BinaryTreeNode<TestMusicInstrument>?)rootField?.GetValue(tree);
        }

        // Вспомогательный метод для сбора элементов с использованием инфиксного обхода (для проверки свойств BST)
        private List<TestMusicInstrument> CollectElementsInOrder(BinaryTreeNode<TestMusicInstrument>? node, List<TestMusicInstrument> elements)
        {
            if (node == null) return elements;
            CollectElementsInOrder(node.Left, elements);
            elements.Add(node.Data);
            CollectElementsInOrder(node.Right, elements);
            return elements;
        }

        // Вспомогательный метод для проверки, является ли дерево корректным Binary Search Tree
        // Проверяет, что левый потомок меньше родителя, а правый потомок больше (на основе CompareTo).
        private bool IsBinarySearchTree(BinaryTreeNode<TestMusicInstrument>? node, TestMusicInstrument? min = null, TestMusicInstrument? max = null)
        {
            if (node == null) return true;

            if (min != null && node.Data.CompareTo(min) <= 0) return false;
            if (max != null && node.Data.CompareTo(max) >= 0) return false;

            return IsBinarySearchTree(node.Left, min, node.Data) &&
                   IsBinarySearchTree(node.Right, node.Data, max);
        }

        // Вспомогательный метод для сбора элементов из любой структуры дерева (похож на приватный CollectElements)
        private void CollectElementsRecursivePublic(BinaryTreeNode<TestMusicInstrument>? node, List<TestMusicInstrument> elements)
        {
            if (node == null) return;
            elements.Add(node.Data);
            CollectElementsRecursivePublic(node.Left, elements);
            CollectElementsRecursivePublic(node.Right, elements);
        }

        // Вспомогательный метод для получения всех узлов в дереве (любой порядок)
        private List<BinaryTreeNode<TestMusicInstrument>> GetAllNodes(BinaryTreeNode<TestMusicInstrument>? node)
        {
            var nodes = new List<BinaryTreeNode<TestMusicInstrument>>();
            if (node != null)
            {
                nodes.Add(node);
                if (node.Left != null) nodes.AddRange(GetAllNodes(node.Left));
                if (node.Right != null) nodes.AddRange(GetAllNodes(node.Right));
            }
            return nodes;
        }

        // Вспомогательный метод для вставки напрямую в корень дерева, имитируя вызовы InsertToSearchTreeRecursive
        // Используется для построения специфических BST для тестов удаления.
        private void InsertIntoTree(BinaryTree<TestMusicInstrument> tree, TestMusicInstrument data)
        {
            var method = typeof(BinaryTree<TestMusicInstrument>)
                           .GetMethod("InsertToSearchTreeRecursive", BindingFlags.NonPublic | BindingFlags.Instance);
            var rootField = typeof(BinaryTree<TestMusicInstrument>)
                               .GetField("root", BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null || rootField == null) throw new InvalidOperationException("Не удалось получить доступ к приватным членам для настройки.");

            var currentRoot = GetRoot(tree);
            var newRoot = method.Invoke(tree, new object?[] { currentRoot, data }); // Вызываем с текущим корнем и данными
            rootField.SetValue(tree, newRoot); // Обновляем поле root
        }

        // Вспомогательный метод для поиска узла по TestValue в BST
        private BinaryTreeNode<TestMusicInstrument>? FindNodeByTestValue(BinaryTreeNode<TestMusicInstrument>? node, int testValue)
        {
            if (node == null) return null;
            if (node.Data.TestValue == testValue) return node;

            // Ищем в левом или правом поддереве согласно свойству BST (используя CompareTo, которое использует TestValue)
            if (testValue.CompareTo(node.Data.TestValue) < 0)
            {
                return FindNodeByTestValue(node.Left, testValue);
            }
            else
            {
                return FindNodeByTestValue(node.Right, testValue);
            }
        }


        [TestMethod]
        public void BinaryTree_Constructor_InitializesWithNullRoot()
        {
            // Arrange & Act
            var tree = new BinaryTree<TestMusicInstrument>(_generator);

            // Assert
            Assert.IsNotNull(tree);
            Assert.IsNull(GetRoot(tree));
        }

        [TestMethod]
        public void CreateIdealTree_SizeZero_RootIsNull()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);

            // Act
            tree.CreateIdealTree(0);

            // Assert
            Assert.IsNull(GetRoot(tree));
            Assert.AreEqual(0, CountNodes(GetRoot(tree)));
        }

        [TestMethod]
        public void CreateIdealTree_SizeOne_CreatesSingleNodeTree()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);

            // Act
            tree.CreateIdealTree(1);

            // Assert
            var root = GetRoot(tree);
            Assert.IsNotNull(root);
            Assert.AreEqual(1, CountNodes(root));
            Assert.IsNull(root?.Left);
            Assert.IsNull(root?.Right);
        }

        [TestMethod]
        public void CreateIdealTree_SizeSeven_CreatesSevenNodes()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);

            // Act
            tree.CreateIdealTree(7);

            // Assert
            var root = GetRoot(tree);
            Assert.IsNotNull(root);
            Assert.AreEqual(7, CountNodes(root));
            // Простая проверка структуры для размера 7 (должна быть глубина 3)
            Assert.IsNotNull(root?.Left);
            Assert.IsNotNull(root?.Right);
            Assert.IsNotNull(root?.Left?.Left);
            Assert.IsNotNull(root?.Left?.Right);
            Assert.IsNotNull(root?.Right?.Left);
            Assert.IsNotNull(root?.Right?.Right);
        }

        [TestMethod]
        public void FindMaxElement_EmptyTree_ReturnsNull()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator); // Дерево изначально пустое

            // Act
            var maxElement = tree.FindMaxElement();

            // Assert
            Assert.IsNull(maxElement);
        }

        [TestMethod]
        public void FindMaxElement_SingleNodeTree_ReturnsClonedData()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);
            tree.CreateIdealTree(1); // Создает дерево с одним узлом (TestValue 5 из генератора)
            var expectedData = new TestMusicInstrument("Instrument_E", 105, 5);

            // Act
            var maxElement = tree.FindMaxElement();

            // Assert
            Assert.IsNotNull(maxElement);
            Assert.AreEqual(expectedData, maxElement);
            Assert.AreNotSame(expectedData, maxElement); // Должен быть клон, а не исходный экземпляр
            Assert.AreNotSame(GetRoot(tree)?.Data, maxElement); // Должен быть клон, а не данные в узле дерева
        }

        [TestMethod]
        public void FindMaxElement_MultipleNodes_ReturnsClonedMaximum()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);
            tree.CreateIdealTree(7); // Создаем дерево с 7 узлами
                                     // Максимальный элемент по CompareTo (использующему TestValue) должен быть тот, у кого TestValue равен 7
            var expectedMaxData = new TestMusicInstrument("Instrument_G", 107, 7); // Это 3-й элемент в _generatedData

            // Act
            var maxElement = tree.FindMaxElement();

            // Assert
            Assert.IsNotNull(maxElement);
            Assert.AreEqual(expectedMaxData, maxElement);
            Assert.AreNotSame(expectedMaxData, maxElement); // Должен быть клон
        }

        [TestMethod]
        public void ConvertToSearchTree_EmptyTree_ReturnsNewEmptyTree()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator); // Пустое дерево

            // Act
            var searchTree = tree.ConvertToSearchTree();

            // Assert
            Assert.IsNotNull(searchTree);
            Assert.AreNotSame(tree, searchTree); // Должен быть новый объект дерева
            Assert.IsNull(GetRoot(searchTree));
            Assert.AreEqual(0, CountNodes(GetRoot(searchTree)));
        }

        [TestMethod]
        public void ConvertToSearchTree_NonEmptyTree_ReturnsValidSearchTreeWithAllElements()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);
            tree.CreateIdealTree(7); // Создаем дерево с 7 узлами

            // Собираем элементы из исходного дерева
            var originalElements = new List<TestMusicInstrument>();
            CollectElementsRecursivePublic(GetRoot(tree), originalElements);
            originalElements = originalElements.OrderBy(mi => mi.TestValue).ToList(); // Сортируем для последующего сравнения

            // Act
            var searchTree = tree.ConvertToSearchTree();

            // Assert
            Assert.IsNotNull(searchTree);
            Assert.AreNotSame(tree, searchTree); // Должен быть новый объект дерева
            Assert.IsNotNull(GetRoot(searchTree));
            Assert.AreEqual(7, CountNodes(GetRoot(searchTree))); // Проверка количества узлов

            // Проверка свойства дерева поиска
            Assert.IsTrue(IsBinarySearchTree(GetRoot(searchTree)), "Преобразованное дерево не является корректным деревом поиска.");

            // Проверка наличия всех элементов из исходного дерева в дереве поиска
            var searchTreeElements = CollectElementsInOrder(GetRoot(searchTree), new List<TestMusicInstrument>());
            searchTreeElements = searchTreeElements.OrderBy(mi => mi.TestValue).ToList(); // Инфиксный обход BST дает отсортированные элементы

            Assert.AreEqual(originalElements.Count, searchTreeElements.Count);
            CollectionAssert.AreEquivalent(originalElements, searchTreeElements); // Проверка эквивалентности коллекций

            // Проверка, что элементы в дереве поиска являются клонами
            var allNodesInSearchTree = GetAllNodes(GetRoot(searchTree)); // Вспомогательный метод для получения всех узлов
            foreach (var node in allNodesInSearchTree)
            {
                var originalElement = originalElements.FirstOrDefault(oe => oe.Equals(node.Data));
                Assert.AreNotSame(originalElement, node.Data, $"Элемент {node.Data} в дереве поиска не является клоном.");
            }
        }

        [TestMethod]
        public void DeleteFromSearchTree_EmptyTree_RemainsEmpty()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator); // Пустое дерево

            // Act
            tree.DeleteFromSearchTree("NonExistentKey");

            // Assert
            Assert.IsNull(GetRoot(tree));
            Assert.AreEqual(0, CountNodes(GetRoot(tree)));
        }

        [TestMethod]
        public void DeleteFromSearchTree_NonExistentKey_TreeRemainsUnchanged()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);
            tree.CreateIdealTree(7);
            var searchTree = tree.ConvertToSearchTree(); // Преобразование в BST

            var initialElements = CollectElementsInOrder(GetRoot(searchTree), new List<TestMusicInstrument>());
            var initialNodeCount = CountNodes(GetRoot(searchTree));
            Assert.AreEqual(7, initialElements.Count, "Ошибка настройки: Неверное количество узлов.");

            // Act
            searchTree.DeleteFromSearchTree("NonExistentKey"); // Попытка удалить несуществующий ключ

            // Assert
            Assert.IsNotNull(GetRoot(searchTree));
            Assert.AreEqual(initialNodeCount, CountNodes(GetRoot(searchTree))); // Количество узлов не должно измениться
            Assert.IsTrue(IsBinarySearchTree(GetRoot(searchTree)), "Дерево должно оставаться корректным BST.");

            // Проверка, что элементы остались прежними
            var elementsAfterDelete = CollectElementsInOrder(GetRoot(searchTree), new List<TestMusicInstrument>());
            CollectionAssert.AreEquivalent(initialElements, elementsAfterDelete);
        }

        [TestMethod]
        public void DeleteFromSearchTree_RootWithNoChildren_RootBecomesNull()
        {
            // Arrange
            var singleNodeTree = new BinaryTree<TestMusicInstrument>(_generator);
            singleNodeTree.CreateIdealTree(1); // Создаем дерево с одним узлом (TestValue 5)
            var searchTree = singleNodeTree.ConvertToSearchTree(); // Преобразуем один узел в BST

            var rootData = GetRoot(searchTree)?.Data;
            Assert.IsNotNull(rootData, "Ошибка настройки: Корень не должен быть null.");

            // Act
            searchTree.DeleteFromSearchTree(rootData?.Name ?? ""); // Удаляем ключ корня

            // Assert
            Assert.IsNull(GetRoot(searchTree)); // Корень должен стать null после удаления единственного узла
            Assert.AreEqual(0, CountNodes(GetRoot(searchTree))); // Количество узлов должно стать 0
        }


        [TestMethod]
        public void DeleteFromSearchTree_LeafNode_NodeIsRemovedAndParentLinkIsNull()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);
            // Создаем дерево и преобразуем в BST
            tree.CreateIdealTree(7);
            var searchTree = tree.ConvertToSearchTree(); 
            var keyToDelete = "Instrument_A"; // TestValue 1

            var initialNodeCount = CountNodes(GetRoot(searchTree));
            Assert.AreEqual(7, initialNodeCount, "Ошибка настройки: Неверное количество узлов.");
            Assert.IsTrue(CollectElementsInOrder(GetRoot(searchTree), new List<TestMusicInstrument>()).Any(e => e.Name == keyToDelete), "Ошибка настройки: Элемент для удаления должен существовать.");


            // Act
            searchTree.DeleteFromSearchTree(keyToDelete);

            // Assert
            Assert.IsNotNull(GetRoot(searchTree));
            Assert.AreEqual(initialNodeCount - 1, CountNodes(GetRoot(searchTree))); // Количество узлов должно уменьшиться на 1
            Assert.IsTrue(IsBinarySearchTree(GetRoot(searchTree)), "Дерево должно оставаться корректным BST после удаления листа.");

            // Проверка, что удаленный элемент отсутствует
            var elementsAfterDelete = CollectElementsInOrder(GetRoot(searchTree), new List<TestMusicInstrument>());
            Assert.IsFalse(elementsAfterDelete.Any(e => e.Name == keyToDelete), "Удаленный элемент не должен быть в дереве.");

            // Проверка, что ссылка у родителя (узел 2) стала null
            var root = GetRoot(searchTree);
            var node2 = FindNodeByTestValue(root, 2);
            Assert.IsNull(node2?.Left, "Левый потомок узла 2 должен стать null после удаления узла 1.");
        }


        [TestMethod]
        public void DeleteFromSearchTree_NodeWithLeftChildOnly_ReplacedByLeftChild()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);
            tree.CreateIdealTree(0); // Начинаем с пустого
            InsertIntoTree(tree, new TestMusicInstrument("Root", 100, 10));
            InsertIntoTree(tree, new TestMusicInstrument("LeftChildOnly", 101, 5));
            InsertIntoTree(tree, new TestMusicInstrument("GrandleftChild", 102, 3)); // Это пойдет влево от 5

            var searchTree = tree; 
            var keyToDelete = "LeftChildOnly"; // TestValue 5
            var initialNodeCount = CountNodes(GetRoot(searchTree));
            Assert.AreEqual(3, initialNodeCount, "Ошибка настройки: Неверное количество узлов.");

            // Act
            searchTree.DeleteFromSearchTree(keyToDelete);

            // Assert
            Assert.IsNotNull(GetRoot(searchTree));
            Assert.AreEqual(initialNodeCount - 1, CountNodes(GetRoot(searchTree))); // Количество узлов должно стать 2
            Assert.IsTrue(IsBinarySearchTree(GetRoot(searchTree)), "Дерево должно оставаться корректным BST после удаления узла с левым потомком.");

            // Проверка, что левый потомок узла 10 теперь узел 3
            var root = GetRoot(searchTree);
            Assert.IsNotNull(root?.Left);
            Assert.AreEqual(3, root?.Left?.Data.TestValue, "Левый потомок корня должен теперь быть внуком (3).");
            Assert.IsNull(root?.Left?.Left, "Новый узел на месте узла 5 не должен иметь левого потомка.");
            Assert.IsNull(root?.Left?.Right, "Новый узел на месте узла 5 не должен иметь правого потомка.");
        }

        [TestMethod]
        public void DeleteFromSearchTree_NodeWithRightChildOnly_ReplacedByRightChild()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);
            tree.CreateIdealTree(0); // Начинаем с пустого
            InsertIntoTree(tree, new TestMusicInstrument("Root", 100, 10));
            InsertIntoTree(tree, new TestMusicInstrument("RightChildOnly", 101, 15));
            InsertIntoTree(tree, new TestMusicInstrument("Grandchild", 102, 17)); // Это пойдет вправо от 15

            var searchTree = tree; 
            var keyToDelete = "RightChildOnly"; // TestValue 15
            var initialNodeCount = CountNodes(GetRoot(searchTree));
            Assert.AreEqual(3, initialNodeCount, "Ошибка настройки: Неверное количество узлов.");

            // Act
            searchTree.DeleteFromSearchTree(keyToDelete);

            // Assert
            Assert.IsNotNull(GetRoot(searchTree));
            Assert.AreEqual(initialNodeCount - 1, CountNodes(GetRoot(searchTree))); // Количество узлов должно стать 2
            Assert.IsTrue(IsBinarySearchTree(GetRoot(searchTree)), "Дерево должно оставаться корректным BST после удаления узла с правым потомком.");

            // Проверка, что правый потомок узла 10 теперь узел 17
            var root = GetRoot(searchTree);
            Assert.IsNotNull(root?.Right);
            Assert.AreEqual(17, root?.Right?.Data.TestValue, "Правый потомок корня должен теперь быть внуком (17).");
            Assert.IsNull(root?.Right?.Left, "Новый узел на месте узла 15 не должен иметь левого потомка.");
            Assert.IsNull(root?.Right?.Right, "Новый узел на месте узла 15 не должен иметь правого потомка.");
        }

        [TestMethod]
        public void DeleteFromSearchTree_NodeWithTwoChildren_ReplacedByInorderSuccessor()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);
            tree.CreateIdealTree(0); // Начинаем с пустого
            InsertIntoTree(tree, new TestMusicInstrument("Node10", 100, 10));
            InsertIntoTree(tree, new TestMusicInstrument("Node05", 101, 5));
            InsertIntoTree(tree, new TestMusicInstrument("Node15", 102, 15));
            InsertIntoTree(tree, new TestMusicInstrument("Node03", 103, 3));
            InsertIntoTree(tree, new TestMusicInstrument("Node07", 104, 7));
            InsertIntoTree(tree, new TestMusicInstrument("Node12", 105, 12));
            InsertIntoTree(tree, new TestMusicInstrument("Node17", 106, 17));

            var searchTree = tree; 
            var keyToDelete = "Node10"; // TestValue 10
            var expectedSuccessorValue = 12;

            var initialNodeCount = CountNodes(GetRoot(searchTree));
            Assert.AreEqual(7, initialNodeCount, "Ошибка настройки: Неверное количество узлов.");
            Assert.IsTrue(CollectElementsInOrder(GetRoot(searchTree), new List<TestMusicInstrument>()).Any(e => e.Name == keyToDelete), "Ошибка настройки: Элемент для удаления должен существовать.");
            Assert.IsTrue(CollectElementsInOrder(GetRoot(searchTree), new List<TestMusicInstrument>()).Any(e => e.TestValue == expectedSuccessorValue), "Ошибка настройки: Преемник должен существовать.");


            // Act
            searchTree.DeleteFromSearchTree(keyToDelete);

            // Assert
            Assert.IsNotNull(GetRoot(searchTree));
            Assert.AreEqual(initialNodeCount - 1, CountNodes(GetRoot(searchTree))); // Количество узлов должно стать 6
            Assert.IsTrue(IsBinarySearchTree(GetRoot(searchTree)), "Дерево должно оставаться корректным BST после удаления узла с двумя потомками.");

            // Проверка, что удаленный элемент (Узел 10) отсутствует
            var elementsAfterDelete = CollectElementsInOrder(GetRoot(searchTree), new List<TestMusicInstrument>());
            Assert.IsFalse(elementsAfterDelete.Any(e => e.Name == keyToDelete), "Удаленный элемент (Узел 10) не должен быть в дереве.");

            // Проверка, что данные нового корня - это инфиксный преемник (Узел 12)
            var root = GetRoot(searchTree);
            Assert.AreEqual(expectedSuccessorValue, root?.Data.TestValue, "Данные нового корня должны быть инфиксным преемником (12).");

            // Проверка, что преемник (Узел 12) удален со своей исходной позиции (левый потомок 15)
            var node15 = FindNodeByTestValue(root, 15);
            Assert.IsNotNull(node15, "Узел 15 должен остаться в дереве.");
            Assert.IsNull(node15?.Left, "Левый потомок узла 15 (который был 12) должен стать null.");
        }


        [TestMethod]
        public void Clear_EmptyTree_RemainsEmpty()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator); // Пустое дерево

            // Act
            tree.Clear();

            // Assert
            Assert.IsNull(GetRoot(tree));
            Assert.AreEqual(0, CountNodes(GetRoot(tree)));
        }

        [TestMethod]
        public void Clear_NonEmptyTree_RootBecomesNull()
        {
            // Arrange
            var tree = new BinaryTree<TestMusicInstrument>(_generator);
            tree.CreateIdealTree(5); // Создаем дерево с узлами
            Assert.IsNotNull(GetRoot(tree), "Ошибка настройки: Дерево не должно быть пустым.");
            Assert.AreEqual(5, CountNodes(GetRoot(tree)), "Ошибка настройки: Неверное количество узлов.");

            // Act
            tree.Clear();

            // Assert
            Assert.IsNull(GetRoot(tree));
            Assert.AreEqual(0, CountNodes(GetRoot(tree)));
        }
    }
}
