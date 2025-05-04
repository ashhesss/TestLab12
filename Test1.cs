using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq; 
using System.Collections.Generic;
using Laba_12;
using MusicInstrumentLibr;


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
            string key = "Guitar1"; // G=71, u=117, i=105, t=116, a=97, r=114, 1=49 -> 71+117+105+116+97+114+49=669
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
}
